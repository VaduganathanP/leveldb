using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb
{
    public unsafe partial class Writebatch
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Writebatch> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Writebatch>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Writebatch __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Writebatch(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Writebatch __CreateInstance(global::Leveldb.Writebatch.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Writebatch(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Writebatch.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Writebatch.__Internal));
            *(global::Leveldb.Writebatch.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Writebatch(global::Leveldb.Writebatch.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Writebatch(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }
}
