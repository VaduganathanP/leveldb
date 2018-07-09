using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb
{
    public unsafe partial class Filterpolicy
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Filterpolicy> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Filterpolicy>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Filterpolicy __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Filterpolicy(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Filterpolicy __CreateInstance(global::Leveldb.Filterpolicy.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Filterpolicy(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Filterpolicy.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Filterpolicy.__Internal));
            *(global::Leveldb.Filterpolicy.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Filterpolicy(global::Leveldb.Filterpolicy.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Filterpolicy(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }
}
