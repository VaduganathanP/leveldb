using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb.Native
{
    public unsafe partial class EnvMethods
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_create_default_env")]
            internal static extern global::System.IntPtr CreateDefaultEnv();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_env_destroy")]
            internal static extern void EnvDestroy(global::System.IntPtr _0);
        }

        public static global::Leveldb.Env CreateDefaultEnv()
        {
            var __ret = __Internal.CreateDefaultEnv();
            global::Leveldb.Env __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::Leveldb.Env.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::Leveldb.Env)global::Leveldb.Env.NativeToManagedMap[__ret];
            else __result0 = global::Leveldb.Env.__CreateInstance(__ret);
            return __result0;
        }

        public static void EnvDestroy(global::Leveldb.Env _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.EnvDestroy(__arg0);
        }
    }
}
