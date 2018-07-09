using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb
{
    public unsafe partial class Cache
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Cache> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Cache>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Cache __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Cache(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Cache __CreateInstance(global::Leveldb.Cache.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Cache(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Cache.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Cache.__Internal));
            *(global::Leveldb.Cache.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Cache(global::Leveldb.Cache.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Cache(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }
}
