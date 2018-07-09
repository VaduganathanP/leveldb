using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb
{
    public unsafe partial class Iterator
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Iterator> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Iterator>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Iterator __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Iterator(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Iterator __CreateInstance(global::Leveldb.Iterator.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Iterator(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Iterator.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Iterator.__Internal));
            *(global::Leveldb.Iterator.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Iterator(global::Leveldb.Iterator.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Iterator(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }
}
