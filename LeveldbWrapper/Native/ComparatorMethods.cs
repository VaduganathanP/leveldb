using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb.Native
{
    public unsafe partial class ComparatorMethods
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_comparator_create")]
            internal static extern global::System.IntPtr ComparatorCreate(global::System.IntPtr state, global::System.IntPtr destructor,
                global::System.IntPtr compare, global::System.IntPtr name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_comparator_destroy")]
            internal static extern void ComparatorDestroy(global::System.IntPtr _0);
        }

        public static global::Leveldb.Comparator ComparatorCreate(global::System.IntPtr state, global::Leveldb.LeveldbDelegates.Action_IntPtr destructor, 
            global::Leveldb.LeveldbDelegates.Func_int_IntPtr_string_ulong_string_ulong compare, global::Leveldb.LeveldbDelegates.Func_IntPtr_IntPtr name)
        {
            var __arg1 = destructor == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(destructor);
            var __arg2 = compare == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(compare);
            var __arg3 = name == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(name);
            var __ret = __Internal.ComparatorCreate(state, __arg1, __arg2, __arg3);
            global::Leveldb.Comparator __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::Leveldb.Comparator.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::Leveldb.Comparator)global::Leveldb.Comparator.NativeToManagedMap[__ret];
            else __result0 = global::Leveldb.Comparator.__CreateInstance(__ret);
            return __result0;
        }

        public static void ComparatorDestroy(global::Leveldb.Comparator _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.ComparatorDestroy(__arg0);
        }
    }
}
