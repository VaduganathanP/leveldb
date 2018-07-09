using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb.Native
{
    public unsafe partial class DatabaseMethods
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_open")]
            internal static extern global::System.IntPtr Open(global::System.IntPtr options, [MarshalAs(UnmanagedType.LPStr)] string name, sbyte** errptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_close")]
            internal static extern void Close(global::System.IntPtr db);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_put")]
            internal static extern void Put(global::System.IntPtr db, global::System.IntPtr options, [MarshalAs(UnmanagedType.LPStr)] string key,
                ulong keylen, [MarshalAs(UnmanagedType.LPStr)] string val, ulong vallen, sbyte** errptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_delete")]
            internal static extern void Delete(global::System.IntPtr db, global::System.IntPtr options, [MarshalAs(UnmanagedType.LPStr)] string key,
                ulong keylen, sbyte** errptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_write")]
            internal static extern void Write(global::System.IntPtr db, global::System.IntPtr options, global::System.IntPtr batch, sbyte** errptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_get")]
            internal static extern sbyte* Get(global::System.IntPtr db, global::System.IntPtr options, [MarshalAs(UnmanagedType.LPStr)] string key,
                ulong keylen, ulong* vallen, sbyte** errptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_create_iterator")]
            internal static extern global::System.IntPtr CreateIterator(global::System.IntPtr db, global::System.IntPtr options);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_create_snapshot")]
            internal static extern global::System.IntPtr CreateSnapshot(global::System.IntPtr db);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_release_snapshot")]
            internal static extern void ReleaseSnapshot(global::System.IntPtr db, global::System.IntPtr snapshot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_property_value")]
            internal static extern sbyte* PropertyValue(global::System.IntPtr db, [MarshalAs(UnmanagedType.LPStr)] string propname);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_approximate_sizes")]
            internal static extern void ApproximateSizes(global::System.IntPtr db, int num_ranges, sbyte** range_start_key, ulong* range_start_key_len,
                sbyte** range_limit_key, ulong* range_limit_key_len, ulong* sizes);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_compact_range")]
            internal static extern void CompactRange(global::System.IntPtr db, [MarshalAs(UnmanagedType.LPStr)] string start_key, ulong start_key_len,
                [MarshalAs(UnmanagedType.LPStr)] string limit_key, ulong limit_key_len);
        }

        public static global::Leveldb.DB Open(global::Leveldb.Options options, string name, sbyte[] errptr)
        {
            var __arg0 = ReferenceEquals(options, null) ? global::System.IntPtr.Zero : options.__Instance;
            var __ret = __Internal.Open(__arg0, name, MarshalHelper.SByteArrayToSbytePtrArray(errptr));
            global::Leveldb.DB __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::Leveldb.DB.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::Leveldb.DB)global::Leveldb.DB.NativeToManagedMap[__ret];
            else __result0 = global::Leveldb.DB.__CreateInstance(__ret);
            return __result0;
        }

        public static void Close(global::Leveldb.DB db)
        {
            var __arg0 = ReferenceEquals(db, null) ? global::System.IntPtr.Zero : db.__Instance;
            __Internal.Close(__arg0);
        }

        public static void Put(global::Leveldb.DB db, global::Leveldb.Writeoptions options, string key, ulong keylen, string val, ulong vallen, sbyte[] errptr)
        {
            var __arg0 = ReferenceEquals(db, null) ? global::System.IntPtr.Zero : db.__Instance;
            var __arg1 = ReferenceEquals(options, null) ? global::System.IntPtr.Zero : options.__Instance;
            __Internal.Put(__arg0, __arg1, key, keylen, val, vallen, MarshalHelper.SByteArrayToSbytePtrArray(errptr));
        }

        public static void Delete(global::Leveldb.DB db, global::Leveldb.Writeoptions options, string key, ulong keylen, sbyte[] errptr)
        {
            var __arg0 = ReferenceEquals(db, null) ? global::System.IntPtr.Zero : db.__Instance;
            var __arg1 = ReferenceEquals(options, null) ? global::System.IntPtr.Zero : options.__Instance;
            __Internal.Delete(__arg0, __arg1, key, keylen, MarshalHelper.SByteArrayToSbytePtrArray(errptr));
        }

        public static void Write(global::Leveldb.DB db, global::Leveldb.Writeoptions options, global::Leveldb.Writebatch batch, sbyte[] errptr)
        {
            var __arg0 = ReferenceEquals(db, null) ? global::System.IntPtr.Zero : db.__Instance;
            var __arg1 = ReferenceEquals(options, null) ? global::System.IntPtr.Zero : options.__Instance;
            var __arg2 = ReferenceEquals(batch, null) ? global::System.IntPtr.Zero : batch.__Instance;
            __Internal.Write(__arg0, __arg1, __arg2, MarshalHelper.SByteArrayToSbytePtrArray(errptr));
        }

        public static byte[] Get(global::Leveldb.DB db, global::Leveldb.Readoptions options, string key, ulong keylen, ref ulong vallen, sbyte[] errptr)
        {
            var __arg0 = ReferenceEquals(db, null) ? global::System.IntPtr.Zero : db.__Instance;
            var __arg1 = ReferenceEquals(options, null) ? global::System.IntPtr.Zero : options.__Instance;
            fixed (ulong* __refParamPtr4 = &vallen)
            {
                var __arg4 = __refParamPtr4;
                var __ret = __Internal.Get(__arg0, __arg1, key, keylen, __arg4, MarshalHelper.SByteArrayToSbytePtrArray(errptr));
                return MarshalHelper.IntPtrToByteArray((IntPtr)__ret, (int)vallen);
            }
        }

        public static global::Leveldb.Iterator CreateIterator(global::Leveldb.DB db, global::Leveldb.Readoptions options)
        {
            var __arg0 = ReferenceEquals(db, null) ? global::System.IntPtr.Zero : db.__Instance;
            var __arg1 = ReferenceEquals(options, null) ? global::System.IntPtr.Zero : options.__Instance;
            var __ret = __Internal.CreateIterator(__arg0, __arg1);
            global::Leveldb.Iterator __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::Leveldb.Iterator.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::Leveldb.Iterator)global::Leveldb.Iterator.NativeToManagedMap[__ret];
            else __result0 = global::Leveldb.Iterator.__CreateInstance(__ret);
            return __result0;
        }

        public static global::Leveldb.Snapshot CreateSnapshot(global::Leveldb.DB db)
        {
            var __arg0 = ReferenceEquals(db, null) ? global::System.IntPtr.Zero : db.__Instance;
            var __ret = __Internal.CreateSnapshot(__arg0);
            global::Leveldb.Snapshot __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::Leveldb.Snapshot.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::Leveldb.Snapshot)global::Leveldb.Snapshot.NativeToManagedMap[__ret];
            else __result0 = global::Leveldb.Snapshot.__CreateInstance(__ret);
            return __result0;
        }

        public static void ReleaseSnapshot(global::Leveldb.DB db, global::Leveldb.Snapshot snapshot)
        {
            var __arg0 = ReferenceEquals(db, null) ? global::System.IntPtr.Zero : db.__Instance;
            var __arg1 = ReferenceEquals(snapshot, null) ? global::System.IntPtr.Zero : snapshot.__Instance;
            __Internal.ReleaseSnapshot(__arg0, __arg1);
        }

        public static sbyte* PropertyValue(global::Leveldb.DB db, string propname)
        {
            var __arg0 = ReferenceEquals(db, null) ? global::System.IntPtr.Zero : db.__Instance;
            var __ret = __Internal.PropertyValue(__arg0, propname);
            return __ret;
        }

        public static void ApproximateSizes(global::Leveldb.DB db, int num_ranges, sbyte[] range_start_key, ref ulong range_start_key_len, 
            sbyte[] range_limit_key, ref ulong range_limit_key_len, ref ulong sizes)
        {
            var __arg0 = ReferenceEquals(db, null) ? global::System.IntPtr.Zero : db.__Instance;
            fixed (ulong* __refParamPtr3 = &range_start_key_len)
            {
                var __arg3 = __refParamPtr3;
                fixed (ulong* __refParamPtr5 = &range_limit_key_len)
                {
                    var __arg5 = __refParamPtr5;
                    fixed (ulong* __refParamPtr6 = &sizes)
                    {
                        var __arg6 = __refParamPtr6;
                        __Internal.ApproximateSizes(__arg0, num_ranges, MarshalHelper.SByteArrayToSbytePtrArray(range_start_key), __arg3, 
                            MarshalHelper.SByteArrayToSbytePtrArray(range_limit_key), __arg5, __arg6);
                    }
                }
            }
        }

        public static void CompactRange(global::Leveldb.DB db, string start_key, ulong start_key_len, string limit_key, ulong limit_key_len)
        {
            var __arg0 = ReferenceEquals(db, null) ? global::System.IntPtr.Zero : db.__Instance;
            __Internal.CompactRange(__arg0, start_key, start_key_len, limit_key, limit_key_len);
        }
    }
}
