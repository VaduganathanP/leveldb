using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb
{
    public unsafe partial class Logger
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Logger> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Logger>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Logger __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Logger(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Logger __CreateInstance(global::Leveldb.Logger.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Logger(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Logger.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Logger.__Internal));
            *(global::Leveldb.Logger.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Logger(global::Leveldb.Logger.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Logger(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }
}
