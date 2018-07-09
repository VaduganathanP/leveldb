using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb.Native
{
    public unsafe partial class Cache
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_cache_create_lru")]
            internal static extern global::System.IntPtr CacheCreateLru(ulong capacity);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_cache_destroy")]
            internal static extern void CacheDestroy(global::System.IntPtr cache);
        }

        public static global::Leveldb.Cache CacheCreateLru(ulong capacity)
        {
            var __ret = __Internal.CacheCreateLru(capacity);
            global::Leveldb.Cache __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::Leveldb.Cache.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::Leveldb.Cache)global::Leveldb.Cache.NativeToManagedMap[__ret];
            else __result0 = global::Leveldb.Cache.__CreateInstance(__ret);
            return __result0;
        }

        public static void CacheDestroy(global::Leveldb.Cache cache)
        {
            var __arg0 = ReferenceEquals(cache, null) ? global::System.IntPtr.Zero : cache.__Instance;
            __Internal.CacheDestroy(__arg0);
        }
    }
}
