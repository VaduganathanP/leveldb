using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb.Native
{
    public unsafe partial class WriteOptionsMethods
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_writeoptions_create")]
            internal static extern global::System.IntPtr WriteoptionsCreate();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_writeoptions_destroy")]
            internal static extern void WriteoptionsDestroy(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_writeoptions_set_sync")]
            internal static extern void WriteoptionsSetSync(global::System.IntPtr _0, byte _1);
        }

        public static global::Leveldb.Writeoptions WriteoptionsCreate()
        {
            var __ret = __Internal.WriteoptionsCreate();
            global::Leveldb.Writeoptions __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::Leveldb.Writeoptions.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::Leveldb.Writeoptions)global::Leveldb.Writeoptions.NativeToManagedMap[__ret];
            else __result0 = global::Leveldb.Writeoptions.__CreateInstance(__ret);
            return __result0;
        }

        public static void WriteoptionsDestroy(global::Leveldb.Writeoptions _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.WriteoptionsDestroy(__arg0);
        }

        public static void WriteoptionsSetSync(global::Leveldb.Writeoptions _0, byte _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.WriteoptionsSetSync(__arg0, _1);
        }
    }
}
