using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb.Native
{
    public unsafe partial class FilterPolicyMethods
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_filterpolicy_create")]
            internal static extern global::System.IntPtr FilterpolicyCreate(global::System.IntPtr state, global::System.IntPtr destructor,
                global::System.IntPtr create_filter, global::System.IntPtr key_may_match, global::System.IntPtr name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_filterpolicy_destroy")]
            internal static extern void FilterpolicyDestroy(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_filterpolicy_create_bloom")]
            internal static extern global::System.IntPtr FilterpolicyCreateBloom(int bits_per_key);
        }
            public static global::Leveldb.Filterpolicy FilterpolicyCreate(global::System.IntPtr state, global::Leveldb.LeveldbDelegates.Action_IntPtr destructor, global::Leveldb.LeveldbDelegates.Func_sbytePtr_IntPtr_sbytePtrPtr_ulongPtr_int_ulongPtr create_filter, global::Leveldb.LeveldbDelegates.Func_byte_IntPtr_string_ulong_string_ulong key_may_match, global::Leveldb.LeveldbDelegates.Func_IntPtr_IntPtr name)
        {
            var __arg1 = destructor == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(destructor);
            var __arg2 = create_filter == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(create_filter);
            var __arg3 = key_may_match == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(key_may_match);
            var __arg4 = name == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(name);
            var __ret = __Internal.FilterpolicyCreate(state, __arg1, __arg2, __arg3, __arg4);
            global::Leveldb.Filterpolicy __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::Leveldb.Filterpolicy.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::Leveldb.Filterpolicy)global::Leveldb.Filterpolicy.NativeToManagedMap[__ret];
            else __result0 = global::Leveldb.Filterpolicy.__CreateInstance(__ret);
            return __result0;
        }

        public static void FilterpolicyDestroy(global::Leveldb.Filterpolicy _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.FilterpolicyDestroy(__arg0);
        }

        public static global::Leveldb.Filterpolicy FilterpolicyCreateBloom(int bits_per_key)
        {
            var __ret = __Internal.FilterpolicyCreateBloom(bits_per_key);
            global::Leveldb.Filterpolicy __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::Leveldb.Filterpolicy.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::Leveldb.Filterpolicy)global::Leveldb.Filterpolicy.NativeToManagedMap[__ret];
            else __result0 = global::Leveldb.Filterpolicy.__CreateInstance(__ret);
            return __result0;
        }
    }
}
