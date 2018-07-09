using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb.Native
{
    public unsafe partial class IteratorMethods
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_destroy")]
            internal static extern void IterDestroy(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_valid")]
            internal static extern byte IterValid(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_seek_to_first")]
            internal static extern void IterSeekToFirst(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_seek_to_last")]
            internal static extern void IterSeekToLast(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_seek")]
            internal static extern void IterSeek(global::System.IntPtr _0, [MarshalAs(UnmanagedType.LPStr)] string k, ulong klen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_next")]
            internal static extern void IterNext(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_prev")]
            internal static extern void IterPrev(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_key")]
            internal static extern global::System.IntPtr IterKey(global::System.IntPtr _0, ulong* klen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_value")]
            internal static extern global::System.IntPtr IterValue(global::System.IntPtr _0, ulong* vlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_get_error")]
            internal static extern void IterGetError(global::System.IntPtr _0, sbyte** errptr);
        }
            public static void IterDestroy(global::Leveldb.Iterator _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.IterDestroy(__arg0);
        }

        public static byte IterValid(global::Leveldb.Iterator _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.IterValid(__arg0);
            return __ret;
        }

        public static void IterSeekToFirst(global::Leveldb.Iterator _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.IterSeekToFirst(__arg0);
        }

        public static void IterSeekToLast(global::Leveldb.Iterator _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.IterSeekToLast(__arg0);
        }

        public static void IterSeek(global::Leveldb.Iterator _0, string k, ulong klen)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.IterSeek(__arg0, k, klen);
        }

        public static void IterNext(global::Leveldb.Iterator _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.IterNext(__arg0);
        }

        public static void IterPrev(global::Leveldb.Iterator _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.IterPrev(__arg0);
        }

        public static string IterKey(global::Leveldb.Iterator _0, ref ulong klen)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            fixed (ulong* __refParamPtr1 = &klen)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.IterKey(__arg0, __arg1);
                return Marshal.PtrToStringAnsi(__ret);
            }
        }

        public static string IterValue(global::Leveldb.Iterator _0, ref ulong vlen)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            fixed (ulong* __refParamPtr1 = &vlen)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.IterValue(__arg0, __arg1);
                return Marshal.PtrToStringAnsi(__ret);
            }
        }

        public static void IterGetError(global::Leveldb.Iterator _0, sbyte** errptr)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.IterGetError(__arg0, errptr);
        }
    }
}
