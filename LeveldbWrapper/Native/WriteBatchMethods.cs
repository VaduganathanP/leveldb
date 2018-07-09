using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb.Native
{
    public unsafe partial class WriteBatchMethods
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_writebatch_create")]
            internal static extern global::System.IntPtr WritebatchCreate();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_writebatch_destroy")]
            internal static extern void WritebatchDestroy(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_writebatch_clear")]
            internal static extern void WritebatchClear(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_writebatch_put")]
            internal static extern void WritebatchPut(global::System.IntPtr _0, [MarshalAs(UnmanagedType.LPStr)] string key, ulong klen,
                [MarshalAs(UnmanagedType.LPStr)] string val, ulong vlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_writebatch_delete")]
            internal static extern void WritebatchDelete(global::System.IntPtr _0, [MarshalAs(UnmanagedType.LPStr)] string key, ulong klen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_writebatch_iterate")]
            internal static extern void WritebatchIterate(global::System.IntPtr _0, global::System.IntPtr state, global::System.IntPtr put,
                global::System.IntPtr deleted);
        }

        public static global::Leveldb.Writebatch WritebatchCreate()
        {
            var __ret = __Internal.WritebatchCreate();
            global::Leveldb.Writebatch __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::Leveldb.Writebatch.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::Leveldb.Writebatch)global::Leveldb.Writebatch.NativeToManagedMap[__ret];
            else __result0 = global::Leveldb.Writebatch.__CreateInstance(__ret);
            return __result0;
        }

        public static void WritebatchDestroy(global::Leveldb.Writebatch _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.WritebatchDestroy(__arg0);
        }

        public static void WritebatchClear(global::Leveldb.Writebatch _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.WritebatchClear(__arg0);
        }

        public static void WritebatchPut(global::Leveldb.Writebatch _0, string key, ulong klen, string val, ulong vlen)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.WritebatchPut(__arg0, key, klen, val, vlen);
        }

        public static void WritebatchDelete(global::Leveldb.Writebatch _0, string key, ulong klen)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.WritebatchDelete(__arg0, key, klen);
        }

        public static void WritebatchIterate(global::Leveldb.Writebatch _0, global::System.IntPtr state, global::Leveldb.LeveldbDelegates.Action_IntPtr_string_ulong_string_ulong put, global::Leveldb.LeveldbDelegates.Action_IntPtr_string_ulong deleted)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            var __arg2 = put == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(put);
            var __arg3 = deleted == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(deleted);
            __Internal.WritebatchIterate(__arg0, state, __arg2, __arg3);
        }
    }
}
