﻿using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb
{
    public unsafe partial class Filelock
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Filelock> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Filelock>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Filelock __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Filelock(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Filelock __CreateInstance(global::Leveldb.Filelock.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Filelock(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Filelock.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Filelock.__Internal));
            *(global::Leveldb.Filelock.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Filelock(global::Leveldb.Filelock.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Filelock(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }
}
