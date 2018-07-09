using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb.Native
{
    public unsafe partial class OptionsMethods
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_create")]
            internal static extern global::System.IntPtr Create();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_destroy")]
            internal static extern void Destroy(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_comparator")]
            internal static extern void SetComparator(global::System.IntPtr _0, global::System.IntPtr _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_filter_policy")]
            internal static extern void SetFilterPolicy(global::System.IntPtr _0, global::System.IntPtr _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_create_if_missing")]
            internal static extern void SetCreateIfMissing(global::System.IntPtr _0, byte _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_error_if_exists")]
            internal static extern void SetErrorIfExists(global::System.IntPtr _0, byte _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_paranoid_checks")]
            internal static extern void SetParanoidChecks(global::System.IntPtr _0, byte _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_env")]
            internal static extern void SetEnv(global::System.IntPtr _0, global::System.IntPtr _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_info_log")]
            internal static extern void SetInfoLog(global::System.IntPtr _0, global::System.IntPtr _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_write_buffer_size")]
            internal static extern void SetWriteBufferSize(global::System.IntPtr _0, ulong _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_max_open_files")]
            internal static extern void SetMaxOpenFiles(global::System.IntPtr _0, int _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_cache")]
            internal static extern void SetCache(global::System.IntPtr _0, global::System.IntPtr _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_block_size")]
            internal static extern void SetBlockSize(global::System.IntPtr _0, ulong _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_block_restart_interval")]
            internal static extern void SetBlockRestartInterval(global::System.IntPtr _0, int _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_compression")]
            internal static extern void SetCompression(global::System.IntPtr _0, int _1);
        }

        public static global::Leveldb.Options Create()
        {
            var __ret = __Internal.Create();
            global::Leveldb.Options __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::Leveldb.Options.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::Leveldb.Options)global::Leveldb.Options.NativeToManagedMap[__ret];
            else __result0 = global::Leveldb.Options.__CreateInstance(__ret);
            return __result0;
        }

        public static void Destroy(global::Leveldb.Options _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.Destroy(__arg0);
        }

        public static void SetComparator(global::Leveldb.Options _0, global::Leveldb.Comparator _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            var __arg1 = ReferenceEquals(_1, null) ? global::System.IntPtr.Zero : _1.__Instance;
            __Internal.SetComparator(__arg0, __arg1);
        }

        public static void SetFilterPolicy(global::Leveldb.Options _0, global::Leveldb.Filterpolicy _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            var __arg1 = ReferenceEquals(_1, null) ? global::System.IntPtr.Zero : _1.__Instance;
            __Internal.SetFilterPolicy(__arg0, __arg1);
        }

        public static void SetCreateIfMissing(global::Leveldb.Options _0, byte _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.SetCreateIfMissing(__arg0, _1);
        }

        public static void SetErrorIfExists(global::Leveldb.Options _0, byte _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.SetErrorIfExists(__arg0, _1);
        }

        public static void SetParanoidChecks(global::Leveldb.Options _0, byte _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.SetParanoidChecks(__arg0, _1);
        }

        public static void SetEnv(global::Leveldb.Options _0, global::Leveldb.Env _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            var __arg1 = ReferenceEquals(_1, null) ? global::System.IntPtr.Zero : _1.__Instance;
            __Internal.SetEnv(__arg0, __arg1);
        }

        public static void SetInfoLog(global::Leveldb.Options _0, global::Leveldb.Logger _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            var __arg1 = ReferenceEquals(_1, null) ? global::System.IntPtr.Zero : _1.__Instance;
            __Internal.SetInfoLog(__arg0, __arg1);
        }

        public static void SetWriteBufferSize(global::Leveldb.Options _0, ulong _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.SetWriteBufferSize(__arg0, _1);
        }

        public static void SetMaxOpenFiles(global::Leveldb.Options _0, int _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.SetMaxOpenFiles(__arg0, _1);
        }

        public static void SetCache(global::Leveldb.Options _0, global::Leveldb.Cache _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            var __arg1 = ReferenceEquals(_1, null) ? global::System.IntPtr.Zero : _1.__Instance;
            __Internal.SetCache(__arg0, __arg1);
        }

        public static void SetBlockSize(global::Leveldb.Options _0, ulong _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.SetBlockSize(__arg0, _1);
        }

        public static void SetBlockRestartInterval(global::Leveldb.Options _0, int _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.SetBlockRestartInterval(__arg0, _1);
        }

        public static void SetCompression(global::Leveldb.Options _0, int _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.SetCompression(__arg0, _1);
        }
    }
}
