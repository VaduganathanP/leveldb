using Leveldb.Native;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb
{
    public unsafe partial class DB : IDisposable
    {
        DB _db = null;
        public DB(sbyte[] err, string dbPath = null, bool isSnappy = true, Options options = null)
        {
            if (options == null)
                options = OptionsMethods.Create();
            OptionsMethods.SetCreateIfMissing(options, 1);
            if (isSnappy)
                OptionsMethods.SetCompression(options, 1);
            else
                OptionsMethods.SetCompression(options, 0);
            if (dbPath == null)
            {
                string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                dbPath = Path.Combine(assemblyPath, "DbFiles");
            }
            if (!Directory.Exists(dbPath))
                Directory.CreateDirectory(dbPath);

            _db = DatabaseMethods.Open(options, dbPath, err);
        }

        public void Put(string key, string value, sbyte[] err, Writeoptions writeoptions = null)
        {
            if (writeoptions == null)
                writeoptions = WriteOptionsMethods.WriteoptionsCreate();
            DatabaseMethods.Put(_db, writeoptions, key, (ulong)key.Length, value, (ulong)value.Length, err);
        }

        public byte[] Get(string key, ref ulong valLen, sbyte[] err, Readoptions readoptions = null)
        {
            if (readoptions == null)
                readoptions = ReadOptionsMethods.ReadoptionsCreate();
            return DatabaseMethods.Get(_db, readoptions, key, (ulong)key.Length, ref valLen, err);
        }

        public void Delete(string key, sbyte[] err, Writeoptions writeoptions = null)
        {
            if (writeoptions == null)
                writeoptions = WriteOptionsMethods.WriteoptionsCreate();
            DatabaseMethods.Delete(_db, writeoptions, key, (ulong)key.Length, err);
        }

        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.DB> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.DB>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.DB __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.DB(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.DB __CreateInstance(global::Leveldb.DB.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.DB(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.DB.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.DB.__Internal));
            *(global::Leveldb.DB.__Internal*)ret = native;
            return ret.ToPointer();
        }

        public void Dispose()
        {
            if (_db != null)
                Leveldb.Native.DatabaseMethods.Close(_db);
        }

        private DB(global::Leveldb.DB.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected DB(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }
}
