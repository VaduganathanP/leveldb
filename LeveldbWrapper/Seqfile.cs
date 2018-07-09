using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb
{
    public unsafe partial class Seqfile
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Seqfile> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Seqfile>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Seqfile __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Seqfile(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Seqfile __CreateInstance(global::Leveldb.Seqfile.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Seqfile(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Seqfile.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Seqfile.__Internal));
            *(global::Leveldb.Seqfile.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Seqfile(global::Leveldb.Seqfile.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Seqfile(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }
}
