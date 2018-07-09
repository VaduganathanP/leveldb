using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb
{
    public unsafe partial class Env
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Env> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Env>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Env __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Env(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Env __CreateInstance(global::Leveldb.Env.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Env(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Env.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Env.__Internal));
            *(global::Leveldb.Env.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Env(global::Leveldb.Env.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Env(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }
}
