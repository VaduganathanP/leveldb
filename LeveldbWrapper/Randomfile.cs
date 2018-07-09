using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb
{
    public unsafe partial class Randomfile
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Randomfile> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Randomfile>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Randomfile __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Randomfile(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Randomfile __CreateInstance(global::Leveldb.Randomfile.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Randomfile(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Randomfile.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Randomfile.__Internal));
            *(global::Leveldb.Randomfile.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Randomfile(global::Leveldb.Randomfile.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Randomfile(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }
}
