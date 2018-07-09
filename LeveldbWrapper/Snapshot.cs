using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb
{
    public unsafe partial class Snapshot
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Snapshot> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Snapshot>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Snapshot __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Snapshot(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Snapshot __CreateInstance(global::Leveldb.Snapshot.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Snapshot(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Snapshot.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Snapshot.__Internal));
            *(global::Leveldb.Snapshot.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Snapshot(global::Leveldb.Snapshot.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Snapshot(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }
}
