using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb.Native
{
    public unsafe partial class ReadOptionsMethods
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_readoptions_create")]
            internal static extern global::System.IntPtr ReadoptionsCreate();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_readoptions_destroy")]
            internal static extern void ReadoptionsDestroy(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_readoptions_set_verify_checksums")]
            internal static extern void ReadoptionsSetVerifyChecksums(global::System.IntPtr _0, byte _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_readoptions_set_fill_cache")]
            internal static extern void ReadoptionsSetFillCache(global::System.IntPtr _0, byte _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_readoptions_set_snapshot")]
            internal static extern void ReadoptionsSetSnapshot(global::System.IntPtr _0, global::System.IntPtr _1);
        }

        public static global::Leveldb.Readoptions ReadoptionsCreate()
        {
            var __ret = __Internal.ReadoptionsCreate();
            global::Leveldb.Readoptions __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::Leveldb.Readoptions.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::Leveldb.Readoptions)global::Leveldb.Readoptions.NativeToManagedMap[__ret];
            else __result0 = global::Leveldb.Readoptions.__CreateInstance(__ret);
            return __result0;
        }

        public static void ReadoptionsDestroy(global::Leveldb.Readoptions _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.ReadoptionsDestroy(__arg0);
        }

        public static void ReadoptionsSetVerifyChecksums(global::Leveldb.Readoptions _0, byte _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.ReadoptionsSetVerifyChecksums(__arg0, _1);
        }

        public static void ReadoptionsSetFillCache(global::Leveldb.Readoptions _0, byte _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.ReadoptionsSetFillCache(__arg0, _1);
        }

        public static void ReadoptionsSetSnapshot(global::Leveldb.Readoptions _0, global::Leveldb.Snapshot _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            var __arg1 = ReferenceEquals(_1, null) ? global::System.IntPtr.Zero : _1.__Instance;
            __Internal.ReadoptionsSetSnapshot(__arg0, __arg1);
        }
    }
}
