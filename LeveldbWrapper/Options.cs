using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb
{
    public unsafe partial class Options
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Options> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Options>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Options __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Options(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Options __CreateInstance(global::Leveldb.Options.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Options(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Options.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Options.__Internal));
            *(global::Leveldb.Options.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Options(global::Leveldb.Options.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Options(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }
}
