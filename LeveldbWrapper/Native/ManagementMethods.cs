using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb.Native
{
    public unsafe partial class ManagementMethods
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_destroy_db")]
            internal static extern void DestroyDb(global::System.IntPtr options, [MarshalAs(UnmanagedType.LPStr)] string name, sbyte** errptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_repair_db")]
            internal static extern void RepairDb(global::System.IntPtr options, [MarshalAs(UnmanagedType.LPStr)] string name, sbyte** errptr);
        }

        public static void DestroyDb(global::Leveldb.Options options, string name, sbyte** errptr)
        {
            var __arg0 = ReferenceEquals(options, null) ? global::System.IntPtr.Zero : options.__Instance;
            __Internal.DestroyDb(__arg0, name, errptr);
        }

        public static void RepairDb(global::Leveldb.Options options, string name, sbyte** errptr)
        {
            var __arg0 = ReferenceEquals(options, null) ? global::System.IntPtr.Zero : options.__Instance;
            __Internal.RepairDb(__arg0, name, errptr);
        }
    }
}
