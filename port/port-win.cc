// LevelDB Copyright (c) 2011 The LevelDB Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file. See the AUTHORS file for names of contributors.
//
// See port_example.h for documentation for the following types/functions.

// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are met:
// 
//  * Redistributions of source code must retain the above copyright
//    notice, this list of conditions and the following disclaimer.
//  * Redistributions in binary form must reproduce the above copyright
//    notice, this list of conditions and the following disclaimer in the
//    documentation and/or other materials provided with the distribution.
//  * Neither the name of the University of California, Berkeley nor the
//    names of its contributors may be used to endorse or promote products
//    derived from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE REGENTS AND CONTRIBUTORS ``AS IS'' AND ANY
// EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE REGENTS AND CONTRIBUTORS BE LIABLE FOR ANY
// DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//

#include "port/port-win.h"

#include <windows.h>
#include <cassert>
#ifdef OS_WIN
#include <limits.h>
#include <intrin.h>
#else
#include <stdint.h>
#endif

namespace leveldb {
	namespace port {

		Mutex::Mutex() :
			cs_(nullptr) {
			assert(!cs_);
			cs_ = static_cast<void *>(new CRITICAL_SECTION());
			::InitializeCriticalSection(static_cast<CRITICAL_SECTION *>(cs_));
			assert(cs_);
		}

		Mutex::~Mutex() {
			assert(cs_);
			::DeleteCriticalSection(static_cast<CRITICAL_SECTION *>(cs_));
			delete static_cast<CRITICAL_SECTION *>(cs_);
			cs_ = nullptr;
			assert(!cs_);
		}

		void Mutex::Lock() {
			assert(cs_);
			::EnterCriticalSection(static_cast<CRITICAL_SECTION *>(cs_));
		}

		void Mutex::Unlock() {
			assert(cs_);
			::LeaveCriticalSection(static_cast<CRITICAL_SECTION *>(cs_));
		}

		void Mutex::AssertHeld() {
			assert(cs_);
			assert(1);
		}

		CondVar::CondVar(Mutex* mu) :
			waiting_(0),
			mu_(mu),
			sem1_(::CreateSemaphore(NULL, 0, 10000, NULL)),
			sem2_(::CreateSemaphore(NULL, 0, 10000, NULL)) {
			assert(mu_);
		}

		CondVar::~CondVar() {
			::CloseHandle(sem1_);
			::CloseHandle(sem2_);
		}

		void CondVar::Wait() {
			mu_->AssertHeld();

			wait_mtx_.Lock();
			++waiting_;
			wait_mtx_.Unlock();

			mu_->Unlock();

			// initiate handshake
			::WaitForSingleObject(sem1_, INFINITE);
			::ReleaseSemaphore(sem2_, 1, NULL);
			mu_->Lock();
		}

		void CondVar::Signal() {
			wait_mtx_.Lock();
			if (waiting_ > 0) {
				--waiting_;

				// finalize handshake
				::ReleaseSemaphore(sem1_, 1, NULL);
				::WaitForSingleObject(sem2_, INFINITE);
			}
			wait_mtx_.Unlock();
		}

		void CondVar::SignalAll() {
			wait_mtx_.Lock();
			for (long i = 0; i < waiting_; ++i) {
				::ReleaseSemaphore(sem1_, 1, NULL);
				while (waiting_ > 0) {
					--waiting_;
					::WaitForSingleObject(sem2_, INFINITE);
				}
			}
			wait_mtx_.Unlock();
		}

		AtomicPointer::AtomicPointer(void* v) {
			Release_Store(v);
		}

		void* AtomicPointer::Acquire_Load() const {
			void * p = nullptr;
			InterlockedExchangePointer(&p, rep_);
			return p;
		}

		void AtomicPointer::Release_Store(void* v) {
			InterlockedExchangePointer(&rep_, v);
		}

		void* AtomicPointer::NoBarrier_Load() const {
			return rep_;
		}

		void AtomicPointer::NoBarrier_Store(void* v) {
			rep_ = v;
		}

#if OS_WIN

		// Used to fetch a naturally-aligned 32-bit word in little endian byte-order
		static inline uint32_t LE_LOAD32(const uint8_t *p) {
			// SSE is x86 only, so ensured that |p| is always little-endian.
			uint32_t word;
			memcpy(&word, p, sizeof(word));
			return word;
		}

#if defined(_M_X64) || defined(__x86_64__)  // LE_LOAD64 is only used on x64.

		// Used to fetch a naturally-aligned 64-bit word in little endian byte-order
		static inline uint64_t LE_LOAD64(const uint8_t *p) {
			uint64_t dword;
			memcpy(&dword, p, sizeof(dword));
			return dword;
		}

#endif  // defined(_M_X64) || defined(__x86_64__)

		static inline bool HaveSSE42() {
#if defined(_MSC_VER)
			int cpu_info[4];
			__cpuid(cpu_info, 1);
			return (cpu_info[2] & (1 << 20)) != 0;
#elif defined(__GNUC__)
			unsigned int eax, ebx, ecx, edx;
			__get_cpuid(1, &eax, &ebx, &ecx, &edx);
			return (ecx & (1 << 20)) != 0;
#else
			return false;
#endif
		}

#endif  // OS_WIN

		uint32_t AcceleratedCRC32C(uint32_t crc, const char* buf, size_t size) {
#if !OS_WIN
			return 0;
#else
			static bool have = HaveSSE42();
			if (!have) {
				return 0;
			}

			const uint8_t *p = reinterpret_cast<const uint8_t *>(buf);
			const uint8_t *e = p + size;
			uint32_t l = crc ^ 0xffffffffu;

#define STEP1 do {                              \
    l = _mm_crc32_u8(l, *p++);                  \
} while (0)
#define STEP4 do {                              \
    l = _mm_crc32_u32(l, LE_LOAD32(p));         \
    p += 4;                                     \
} while (0)
#define STEP8 do {                              \
    l = _mm_crc32_u64(l, LE_LOAD64(p));         \
    p += 8;                                     \
} while (0)

			if (size > 16) {
				// Process unaligned bytes
				for (unsigned int i = reinterpret_cast<uintptr_t>(p) % 8; i; --i) {
					STEP1;
				}

				// _mm_crc32_u64 is only available on x64.
#if defined(_M_X64) || defined(__x86_64__)
				// Process 8 bytes at a time
				while ((e - p) >= 8) {
					STEP8;
				}
				// Process 4 bytes at a time
				if ((e - p) >= 4) {
					STEP4;
				}
#else  // !(defined(_M_X64) || defined(__x86_64__))
				// Process 4 bytes at a time
				while ((e - p) >= 4) {
					STEP4;
				}
#endif  // defined(_M_X64) || defined(__x86_64__)
			}
			// Process the last few bytes
			while (p != e) {
				STEP1;
			}
#undef STEP8
#undef STEP4
#undef STEP1
			return l ^ 0xffffffffu;
#endif  // OS_WIN
		}

	}
}