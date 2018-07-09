using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb
{
    public unsafe partial class Readoptions
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Readoptions> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Readoptions>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Readoptions __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Readoptions(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Readoptions __CreateInstance(global::Leveldb.Readoptions.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Readoptions(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Readoptions.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Readoptions.__Internal));
            *(global::Leveldb.Readoptions.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Readoptions(global::Leveldb.Readoptions.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Readoptions(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }
}
