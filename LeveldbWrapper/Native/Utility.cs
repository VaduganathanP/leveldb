using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb.Native
{
    public unsafe partial class Utility
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_free")]
            internal static extern void Free(global::System.IntPtr ptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_major_version")]
            internal static extern int MajorVersion();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_minor_version")]
            internal static extern int MinorVersion();
        }

        public static void Free(global::System.IntPtr ptr)
        {
            __Internal.Free(ptr);
        }

        public static int MajorVersion()
        {
            var __ret = __Internal.MajorVersion();
            return __ret;
        }

        public static int MinorVersion()
        {
            var __ret = __Internal.MinorVersion();
            return __ret;
        }
    }
}
