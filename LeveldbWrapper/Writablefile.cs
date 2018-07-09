using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb
{
    public unsafe partial class Writablefile
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Writablefile> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Writablefile>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Writablefile __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Writablefile(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Writablefile __CreateInstance(global::Leveldb.Writablefile.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Writablefile(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Writablefile.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Writablefile.__Internal));
            *(global::Leveldb.Writablefile.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Writablefile(global::Leveldb.Writablefile.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Writablefile(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }
}
