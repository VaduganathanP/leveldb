using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb
{
    public unsafe partial class Writeoptions
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Writeoptions> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Writeoptions>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Writeoptions __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Writeoptions(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Writeoptions __CreateInstance(global::Leveldb.Writeoptions.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Writeoptions(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Writeoptions.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Writeoptions.__Internal));
            *(global::Leveldb.Writeoptions.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Writeoptions(global::Leveldb.Writeoptions.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Writeoptions(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }
}
