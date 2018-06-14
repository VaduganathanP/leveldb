using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb
{
    public enum CompressionType
    {
        LeveldbNoCompression = 0,
        LeveldbSnappyCompression = 1
    }

    public unsafe partial class DB
    {
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

    public unsafe partial class Cache
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Cache> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Cache>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Cache __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Cache(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Cache __CreateInstance(global::Leveldb.Cache.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Cache(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Cache.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Cache.__Internal));
            *(global::Leveldb.Cache.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Cache(global::Leveldb.Cache.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Cache(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    public unsafe partial class Comparator
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Comparator> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Comparator>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Comparator __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Comparator(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Comparator __CreateInstance(global::Leveldb.Comparator.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Comparator(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Comparator.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Comparator.__Internal));
            *(global::Leveldb.Comparator.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Comparator(global::Leveldb.Comparator.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Comparator(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    public unsafe partial class Env
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Env> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Env>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Env __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Env(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Env __CreateInstance(global::Leveldb.Env.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Env(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Env.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Env.__Internal));
            *(global::Leveldb.Env.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Env(global::Leveldb.Env.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Env(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    public unsafe partial class Filelock
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Filelock> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Filelock>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Filelock __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Filelock(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Filelock __CreateInstance(global::Leveldb.Filelock.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Filelock(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Filelock.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Filelock.__Internal));
            *(global::Leveldb.Filelock.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Filelock(global::Leveldb.Filelock.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Filelock(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    public unsafe partial class Filterpolicy
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Filterpolicy> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Filterpolicy>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Filterpolicy __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Filterpolicy(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Filterpolicy __CreateInstance(global::Leveldb.Filterpolicy.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Filterpolicy(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Filterpolicy.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Filterpolicy.__Internal));
            *(global::Leveldb.Filterpolicy.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Filterpolicy(global::Leveldb.Filterpolicy.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Filterpolicy(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    public unsafe partial class Iterator
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Iterator> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Iterator>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Iterator __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Iterator(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Iterator __CreateInstance(global::Leveldb.Iterator.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Iterator(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Iterator.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Iterator.__Internal));
            *(global::Leveldb.Iterator.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Iterator(global::Leveldb.Iterator.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Iterator(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    public unsafe partial class Logger
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Logger> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Logger>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Logger __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Logger(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Logger __CreateInstance(global::Leveldb.Logger.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Logger(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Logger.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Logger.__Internal));
            *(global::Leveldb.Logger.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Logger(global::Leveldb.Logger.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Logger(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    public unsafe partial class Options
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Options> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Options>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Options __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Options(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Options __CreateInstance(global::Leveldb.Options.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Options(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Options.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Options.__Internal));
            *(global::Leveldb.Options.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Options(global::Leveldb.Options.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Options(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    public unsafe partial class Randomfile
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Randomfile> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Randomfile>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Randomfile __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Randomfile(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Randomfile __CreateInstance(global::Leveldb.Randomfile.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Randomfile(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Randomfile.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Randomfile.__Internal));
            *(global::Leveldb.Randomfile.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Randomfile(global::Leveldb.Randomfile.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Randomfile(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    public unsafe partial class Readoptions
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Readoptions> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Readoptions>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Readoptions __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Readoptions(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Readoptions __CreateInstance(global::Leveldb.Readoptions.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Readoptions(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Readoptions.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Readoptions.__Internal));
            *(global::Leveldb.Readoptions.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Readoptions(global::Leveldb.Readoptions.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Readoptions(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    public unsafe partial class Seqfile
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Seqfile> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Seqfile>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Seqfile __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Seqfile(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Seqfile __CreateInstance(global::Leveldb.Seqfile.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Seqfile(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Seqfile.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Seqfile.__Internal));
            *(global::Leveldb.Seqfile.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Seqfile(global::Leveldb.Seqfile.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Seqfile(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    public unsafe partial class Snapshot
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Snapshot> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Snapshot>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Snapshot __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Snapshot(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Snapshot __CreateInstance(global::Leveldb.Snapshot.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Snapshot(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Snapshot.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Snapshot.__Internal));
            *(global::Leveldb.Snapshot.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Snapshot(global::Leveldb.Snapshot.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Snapshot(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    public unsafe partial class Writablefile
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Writablefile> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Writablefile>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Writablefile __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Writablefile(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Writablefile __CreateInstance(global::Leveldb.Writablefile.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Writablefile(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Writablefile.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Writablefile.__Internal));
            *(global::Leveldb.Writablefile.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Writablefile(global::Leveldb.Writablefile.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Writablefile(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    public unsafe partial class Writebatch
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Writebatch> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Writebatch>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Writebatch __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Writebatch(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Writebatch __CreateInstance(global::Leveldb.Writebatch.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Writebatch(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Writebatch.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Writebatch.__Internal));
            *(global::Leveldb.Writebatch.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Writebatch(global::Leveldb.Writebatch.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Writebatch(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    public unsafe partial class Writeoptions
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Writeoptions> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Leveldb.Writeoptions>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Leveldb.Writeoptions __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Leveldb.Writeoptions(native.ToPointer(), skipVTables);
        }

        internal static global::Leveldb.Writeoptions __CreateInstance(global::Leveldb.Writeoptions.__Internal native, bool skipVTables = false)
        {
            return new global::Leveldb.Writeoptions(native, skipVTables);
        }

        private static void* __CopyValue(global::Leveldb.Writeoptions.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Leveldb.Writeoptions.__Internal));
            *(global::Leveldb.Writeoptions.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Writeoptions(global::Leveldb.Writeoptions.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Writeoptions(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    //Native Level DB Methods
    public unsafe partial class NLDB
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_open")]
            internal static extern global::System.IntPtr LeveldbOpen(global::System.IntPtr options, [MarshalAs(UnmanagedType.LPStr)] string name, sbyte** errptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_close")]
            internal static extern void LeveldbClose(global::System.IntPtr db);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_put")]
            internal static extern void LeveldbPut(global::System.IntPtr db, global::System.IntPtr options, [MarshalAs(UnmanagedType.LPStr)] string key, ulong keylen, [MarshalAs(UnmanagedType.LPStr)] string val, ulong vallen, sbyte** errptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_delete")]
            internal static extern void LeveldbDelete(global::System.IntPtr db, global::System.IntPtr options, [MarshalAs(UnmanagedType.LPStr)] string key, ulong keylen, sbyte** errptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_write")]
            internal static extern void LeveldbWrite(global::System.IntPtr db, global::System.IntPtr options, global::System.IntPtr batch, sbyte** errptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_get")]
            internal static extern sbyte* LeveldbGet(global::System.IntPtr db, global::System.IntPtr options, [MarshalAs(UnmanagedType.LPStr)] string key, ulong keylen, ulong* vallen, sbyte** errptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_create_iterator")]
            internal static extern global::System.IntPtr LeveldbCreateIterator(global::System.IntPtr db, global::System.IntPtr options);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_create_snapshot")]
            internal static extern global::System.IntPtr LeveldbCreateSnapshot(global::System.IntPtr db);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_release_snapshot")]
            internal static extern void LeveldbReleaseSnapshot(global::System.IntPtr db, global::System.IntPtr snapshot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_property_value")]
            internal static extern sbyte* LeveldbPropertyValue(global::System.IntPtr db, [MarshalAs(UnmanagedType.LPStr)] string propname);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_approximate_sizes")]
            internal static extern void LeveldbApproximateSizes(global::System.IntPtr db, int num_ranges, sbyte** range_start_key, ulong* range_start_key_len, sbyte** range_limit_key, ulong* range_limit_key_len, ulong* sizes);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_compact_range")]
            internal static extern void LeveldbCompactRange(global::System.IntPtr db, [MarshalAs(UnmanagedType.LPStr)] string start_key, ulong start_key_len, [MarshalAs(UnmanagedType.LPStr)] string limit_key, ulong limit_key_len);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_destroy_db")]
            internal static extern void LeveldbDestroyDb(global::System.IntPtr options, [MarshalAs(UnmanagedType.LPStr)] string name, sbyte** errptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_repair_db")]
            internal static extern void LeveldbRepairDb(global::System.IntPtr options, [MarshalAs(UnmanagedType.LPStr)] string name, sbyte** errptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_destroy")]
            internal static extern void LeveldbIterDestroy(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_valid")]
            internal static extern byte LeveldbIterValid(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_seek_to_first")]
            internal static extern void LeveldbIterSeekToFirst(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_seek_to_last")]
            internal static extern void LeveldbIterSeekToLast(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_seek")]
            internal static extern void LeveldbIterSeek(global::System.IntPtr _0, [MarshalAs(UnmanagedType.LPStr)] string k, ulong klen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_next")]
            internal static extern void LeveldbIterNext(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_prev")]
            internal static extern void LeveldbIterPrev(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_key")]
            internal static extern global::System.IntPtr LeveldbIterKey(global::System.IntPtr _0, ulong* klen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_value")]
            internal static extern global::System.IntPtr LeveldbIterValue(global::System.IntPtr _0, ulong* vlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_iter_get_error")]
            internal static extern void LeveldbIterGetError(global::System.IntPtr _0, sbyte** errptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_writebatch_create")]
            internal static extern global::System.IntPtr LeveldbWritebatchCreate();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_writebatch_destroy")]
            internal static extern void LeveldbWritebatchDestroy(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_writebatch_clear")]
            internal static extern void LeveldbWritebatchClear(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_writebatch_put")]
            internal static extern void LeveldbWritebatchPut(global::System.IntPtr _0, [MarshalAs(UnmanagedType.LPStr)] string key, ulong klen, [MarshalAs(UnmanagedType.LPStr)] string val, ulong vlen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_writebatch_delete")]
            internal static extern void LeveldbWritebatchDelete(global::System.IntPtr _0, [MarshalAs(UnmanagedType.LPStr)] string key, ulong klen);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_writebatch_iterate")]
            internal static extern void LeveldbWritebatchIterate(global::System.IntPtr _0, global::System.IntPtr state, global::System.IntPtr put, global::System.IntPtr deleted);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_create")]
            internal static extern global::System.IntPtr LeveldbOptionsCreate();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_destroy")]
            internal static extern void LeveldbOptionsDestroy(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_comparator")]
            internal static extern void LeveldbOptionsSetComparator(global::System.IntPtr _0, global::System.IntPtr _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_filter_policy")]
            internal static extern void LeveldbOptionsSetFilterPolicy(global::System.IntPtr _0, global::System.IntPtr _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_create_if_missing")]
            internal static extern void LeveldbOptionsSetCreateIfMissing(global::System.IntPtr _0, byte _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_error_if_exists")]
            internal static extern void LeveldbOptionsSetErrorIfExists(global::System.IntPtr _0, byte _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_paranoid_checks")]
            internal static extern void LeveldbOptionsSetParanoidChecks(global::System.IntPtr _0, byte _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_env")]
            internal static extern void LeveldbOptionsSetEnv(global::System.IntPtr _0, global::System.IntPtr _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_info_log")]
            internal static extern void LeveldbOptionsSetInfoLog(global::System.IntPtr _0, global::System.IntPtr _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_write_buffer_size")]
            internal static extern void LeveldbOptionsSetWriteBufferSize(global::System.IntPtr _0, ulong _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_max_open_files")]
            internal static extern void LeveldbOptionsSetMaxOpenFiles(global::System.IntPtr _0, int _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_cache")]
            internal static extern void LeveldbOptionsSetCache(global::System.IntPtr _0, global::System.IntPtr _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_block_size")]
            internal static extern void LeveldbOptionsSetBlockSize(global::System.IntPtr _0, ulong _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_block_restart_interval")]
            internal static extern void LeveldbOptionsSetBlockRestartInterval(global::System.IntPtr _0, int _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_options_set_compression")]
            internal static extern void LeveldbOptionsSetCompression(global::System.IntPtr _0, int _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_comparator_create")]
            internal static extern global::System.IntPtr LeveldbComparatorCreate(global::System.IntPtr state, global::System.IntPtr destructor, global::System.IntPtr compare, global::System.IntPtr name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_comparator_destroy")]
            internal static extern void LeveldbComparatorDestroy(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_filterpolicy_create")]
            internal static extern global::System.IntPtr LeveldbFilterpolicyCreate(global::System.IntPtr state, global::System.IntPtr destructor, global::System.IntPtr create_filter, global::System.IntPtr key_may_match, global::System.IntPtr name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_filterpolicy_destroy")]
            internal static extern void LeveldbFilterpolicyDestroy(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_filterpolicy_create_bloom")]
            internal static extern global::System.IntPtr LeveldbFilterpolicyCreateBloom(int bits_per_key);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_readoptions_create")]
            internal static extern global::System.IntPtr LeveldbReadoptionsCreate();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_readoptions_destroy")]
            internal static extern void LeveldbReadoptionsDestroy(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_readoptions_set_verify_checksums")]
            internal static extern void LeveldbReadoptionsSetVerifyChecksums(global::System.IntPtr _0, byte _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_readoptions_set_fill_cache")]
            internal static extern void LeveldbReadoptionsSetFillCache(global::System.IntPtr _0, byte _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_readoptions_set_snapshot")]
            internal static extern void LeveldbReadoptionsSetSnapshot(global::System.IntPtr _0, global::System.IntPtr _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_writeoptions_create")]
            internal static extern global::System.IntPtr LeveldbWriteoptionsCreate();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_writeoptions_destroy")]
            internal static extern void LeveldbWriteoptionsDestroy(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_writeoptions_set_sync")]
            internal static extern void LeveldbWriteoptionsSetSync(global::System.IntPtr _0, byte _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_cache_create_lru")]
            internal static extern global::System.IntPtr LeveldbCacheCreateLru(ulong capacity);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_cache_destroy")]
            internal static extern void LeveldbCacheDestroy(global::System.IntPtr cache);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_create_default_env")]
            internal static extern global::System.IntPtr LeveldbCreateDefaultEnv();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_env_destroy")]
            internal static extern void LeveldbEnvDestroy(global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_free")]
            internal static extern void LeveldbFree(global::System.IntPtr ptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_major_version")]
            internal static extern int LeveldbMajorVersion();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("NitraLeveldb", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "leveldb_minor_version")]
            internal static extern int LeveldbMinorVersion();
        }

        public static global::Leveldb.DB Open(global::Leveldb.Options options, string name, sbyte** errptr)
        {
            var __arg0 = ReferenceEquals(options, null) ? global::System.IntPtr.Zero : options.__Instance;
            var __ret = __Internal.LeveldbOpen(__arg0, name, errptr);
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
            __Internal.LeveldbClose(__arg0);
        }

        public static void Put(global::Leveldb.DB db, global::Leveldb.Writeoptions options, string key, ulong keylen, string val, ulong vallen, sbyte** errptr)
        {
            var __arg0 = ReferenceEquals(db, null) ? global::System.IntPtr.Zero : db.__Instance;
            var __arg1 = ReferenceEquals(options, null) ? global::System.IntPtr.Zero : options.__Instance;
            __Internal.LeveldbPut(__arg0, __arg1, key, keylen, val, vallen, errptr);
        }

        public static void Delete(global::Leveldb.DB db, global::Leveldb.Writeoptions options, string key, ulong keylen, sbyte** errptr)
        {
            var __arg0 = ReferenceEquals(db, null) ? global::System.IntPtr.Zero : db.__Instance;
            var __arg1 = ReferenceEquals(options, null) ? global::System.IntPtr.Zero : options.__Instance;
            __Internal.LeveldbDelete(__arg0, __arg1, key, keylen, errptr);
        }

        public static void Write(global::Leveldb.DB db, global::Leveldb.Writeoptions options, global::Leveldb.Writebatch batch, sbyte** errptr)
        {
            var __arg0 = ReferenceEquals(db, null) ? global::System.IntPtr.Zero : db.__Instance;
            var __arg1 = ReferenceEquals(options, null) ? global::System.IntPtr.Zero : options.__Instance;
            var __arg2 = ReferenceEquals(batch, null) ? global::System.IntPtr.Zero : batch.__Instance;
            __Internal.LeveldbWrite(__arg0, __arg1, __arg2, errptr);
        }

        public static sbyte* Get(global::Leveldb.DB db, global::Leveldb.Readoptions options, string key, ulong keylen, ref ulong vallen, sbyte** errptr)
        {
            var __arg0 = ReferenceEquals(db, null) ? global::System.IntPtr.Zero : db.__Instance;
            var __arg1 = ReferenceEquals(options, null) ? global::System.IntPtr.Zero : options.__Instance;
            fixed (ulong* __refParamPtr4 = &vallen)
            {
                var __arg4 = __refParamPtr4;
                var __ret = __Internal.LeveldbGet(__arg0, __arg1, key, keylen, __arg4, errptr);
                return __ret;
            }
        }

        public static global::Leveldb.Iterator CreateIterator(global::Leveldb.DB db, global::Leveldb.Readoptions options)
        {
            var __arg0 = ReferenceEquals(db, null) ? global::System.IntPtr.Zero : db.__Instance;
            var __arg1 = ReferenceEquals(options, null) ? global::System.IntPtr.Zero : options.__Instance;
            var __ret = __Internal.LeveldbCreateIterator(__arg0, __arg1);
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
            var __ret = __Internal.LeveldbCreateSnapshot(__arg0);
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
            __Internal.LeveldbReleaseSnapshot(__arg0, __arg1);
        }

        public static sbyte* PropertyValue(global::Leveldb.DB db, string propname)
        {
            var __arg0 = ReferenceEquals(db, null) ? global::System.IntPtr.Zero : db.__Instance;
            var __ret = __Internal.LeveldbPropertyValue(__arg0, propname);
            return __ret;
        }

        public static void ApproximateSizes(global::Leveldb.DB db, int num_ranges, sbyte** range_start_key, ref ulong range_start_key_len, sbyte** range_limit_key, ref ulong range_limit_key_len, ref ulong sizes)
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
                        __Internal.LeveldbApproximateSizes(__arg0, num_ranges, range_start_key, __arg3, range_limit_key, __arg5, __arg6);
                    }
                }
            }
        }

        public static void CompactRange(global::Leveldb.DB db, string start_key, ulong start_key_len, string limit_key, ulong limit_key_len)
        {
            var __arg0 = ReferenceEquals(db, null) ? global::System.IntPtr.Zero : db.__Instance;
            __Internal.LeveldbCompactRange(__arg0, start_key, start_key_len, limit_key, limit_key_len);
        }

        public static void DestroyDb(global::Leveldb.Options options, string name, sbyte** errptr)
        {
            var __arg0 = ReferenceEquals(options, null) ? global::System.IntPtr.Zero : options.__Instance;
            __Internal.LeveldbDestroyDb(__arg0, name, errptr);
        }

        public static void RepairDb(global::Leveldb.Options options, string name, sbyte** errptr)
        {
            var __arg0 = ReferenceEquals(options, null) ? global::System.IntPtr.Zero : options.__Instance;
            __Internal.LeveldbRepairDb(__arg0, name, errptr);
        }

        public static void IterDestroy(global::Leveldb.Iterator _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbIterDestroy(__arg0);
        }

        public static byte IterValid(global::Leveldb.Iterator _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.LeveldbIterValid(__arg0);
            return __ret;
        }

        public static void IterSeekToFirst(global::Leveldb.Iterator _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbIterSeekToFirst(__arg0);
        }

        public static void IterSeekToLast(global::Leveldb.Iterator _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbIterSeekToLast(__arg0);
        }

        public static void IterSeek(global::Leveldb.Iterator _0, string k, ulong klen)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbIterSeek(__arg0, k, klen);
        }

        public static void IterNext(global::Leveldb.Iterator _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbIterNext(__arg0);
        }

        public static void IterPrev(global::Leveldb.Iterator _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbIterPrev(__arg0);
        }

        public static string IterKey(global::Leveldb.Iterator _0, ref ulong klen)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            fixed (ulong* __refParamPtr1 = &klen)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.LeveldbIterKey(__arg0, __arg1);
                return Marshal.PtrToStringAnsi(__ret);
            }
        }

        public static string IterValue(global::Leveldb.Iterator _0, ref ulong vlen)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            fixed (ulong* __refParamPtr1 = &vlen)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.LeveldbIterValue(__arg0, __arg1);
                return Marshal.PtrToStringAnsi(__ret);
            }
        }

        public static void IterGetError(global::Leveldb.Iterator _0, sbyte** errptr)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbIterGetError(__arg0, errptr);
        }

        public static global::Leveldb.Writebatch WritebatchCreate()
        {
            var __ret = __Internal.LeveldbWritebatchCreate();
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
            __Internal.LeveldbWritebatchDestroy(__arg0);
        }

        public static void WritebatchClear(global::Leveldb.Writebatch _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbWritebatchClear(__arg0);
        }

        public static void WritebatchPut(global::Leveldb.Writebatch _0, string key, ulong klen, string val, ulong vlen)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbWritebatchPut(__arg0, key, klen, val, vlen);
        }

        public static void WritebatchDelete(global::Leveldb.Writebatch _0, string key, ulong klen)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbWritebatchDelete(__arg0, key, klen);
        }

        public static void WritebatchIterate(global::Leveldb.Writebatch _0, global::System.IntPtr state, global::Leveldb.LeveldbDelegates.Action_IntPtr_string_ulong_string_ulong put, global::Leveldb.LeveldbDelegates.Action_IntPtr_string_ulong deleted)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            var __arg2 = put == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(put);
            var __arg3 = deleted == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(deleted);
            __Internal.LeveldbWritebatchIterate(__arg0, state, __arg2, __arg3);
        }

        public static global::Leveldb.Options OptionsCreate()
        {
            var __ret = __Internal.LeveldbOptionsCreate();
            global::Leveldb.Options __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::Leveldb.Options.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::Leveldb.Options)global::Leveldb.Options.NativeToManagedMap[__ret];
            else __result0 = global::Leveldb.Options.__CreateInstance(__ret);
            return __result0;
        }

        public static void OptionsDestroy(global::Leveldb.Options _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbOptionsDestroy(__arg0);
        }

        public static void OptionsSetComparator(global::Leveldb.Options _0, global::Leveldb.Comparator _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            var __arg1 = ReferenceEquals(_1, null) ? global::System.IntPtr.Zero : _1.__Instance;
            __Internal.LeveldbOptionsSetComparator(__arg0, __arg1);
        }

        public static void OptionsSetFilterPolicy(global::Leveldb.Options _0, global::Leveldb.Filterpolicy _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            var __arg1 = ReferenceEquals(_1, null) ? global::System.IntPtr.Zero : _1.__Instance;
            __Internal.LeveldbOptionsSetFilterPolicy(__arg0, __arg1);
        }

        public static void OptionsSetCreateIfMissing(global::Leveldb.Options _0, byte _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbOptionsSetCreateIfMissing(__arg0, _1);
        }

        public static void OptionsSetErrorIfExists(global::Leveldb.Options _0, byte _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbOptionsSetErrorIfExists(__arg0, _1);
        }

        public static void OptionsSetParanoidChecks(global::Leveldb.Options _0, byte _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbOptionsSetParanoidChecks(__arg0, _1);
        }

        public static void OptionsSetEnv(global::Leveldb.Options _0, global::Leveldb.Env _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            var __arg1 = ReferenceEquals(_1, null) ? global::System.IntPtr.Zero : _1.__Instance;
            __Internal.LeveldbOptionsSetEnv(__arg0, __arg1);
        }

        public static void OptionsSetInfoLog(global::Leveldb.Options _0, global::Leveldb.Logger _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            var __arg1 = ReferenceEquals(_1, null) ? global::System.IntPtr.Zero : _1.__Instance;
            __Internal.LeveldbOptionsSetInfoLog(__arg0, __arg1);
        }

        public static void OptionsSetWriteBufferSize(global::Leveldb.Options _0, ulong _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbOptionsSetWriteBufferSize(__arg0, _1);
        }

        public static void OptionsSetMaxOpenFiles(global::Leveldb.Options _0, int _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbOptionsSetMaxOpenFiles(__arg0, _1);
        }

        public static void OptionsSetCache(global::Leveldb.Options _0, global::Leveldb.Cache _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            var __arg1 = ReferenceEquals(_1, null) ? global::System.IntPtr.Zero : _1.__Instance;
            __Internal.LeveldbOptionsSetCache(__arg0, __arg1);
        }

        public static void OptionsSetBlockSize(global::Leveldb.Options _0, ulong _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbOptionsSetBlockSize(__arg0, _1);
        }

        public static void OptionsSetBlockRestartInterval(global::Leveldb.Options _0, int _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbOptionsSetBlockRestartInterval(__arg0, _1);
        }

        public static void OptionsSetCompression(global::Leveldb.Options _0, int _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbOptionsSetCompression(__arg0, _1);
        }

        public static global::Leveldb.Comparator ComparatorCreate(global::System.IntPtr state, global::Leveldb.LeveldbDelegates.Action_IntPtr destructor, global::Leveldb.LeveldbDelegates.Func_int_IntPtr_string_ulong_string_ulong compare, global::Leveldb.LeveldbDelegates.Func_IntPtr_IntPtr name)
        {
            var __arg1 = destructor == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(destructor);
            var __arg2 = compare == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(compare);
            var __arg3 = name == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(name);
            var __ret = __Internal.LeveldbComparatorCreate(state, __arg1, __arg2, __arg3);
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
            __Internal.LeveldbComparatorDestroy(__arg0);
        }

        public static global::Leveldb.Filterpolicy FilterpolicyCreate(global::System.IntPtr state, global::Leveldb.LeveldbDelegates.Action_IntPtr destructor, global::Leveldb.LeveldbDelegates.Func_sbytePtr_IntPtr_sbytePtrPtr_ulongPtr_int_ulongPtr create_filter, global::Leveldb.LeveldbDelegates.Func_byte_IntPtr_string_ulong_string_ulong key_may_match, global::Leveldb.LeveldbDelegates.Func_IntPtr_IntPtr name)
        {
            var __arg1 = destructor == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(destructor);
            var __arg2 = create_filter == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(create_filter);
            var __arg3 = key_may_match == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(key_may_match);
            var __arg4 = name == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(name);
            var __ret = __Internal.LeveldbFilterpolicyCreate(state, __arg1, __arg2, __arg3, __arg4);
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
            __Internal.LeveldbFilterpolicyDestroy(__arg0);
        }

        public static global::Leveldb.Filterpolicy FilterpolicyCreateBloom(int bits_per_key)
        {
            var __ret = __Internal.LeveldbFilterpolicyCreateBloom(bits_per_key);
            global::Leveldb.Filterpolicy __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::Leveldb.Filterpolicy.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::Leveldb.Filterpolicy)global::Leveldb.Filterpolicy.NativeToManagedMap[__ret];
            else __result0 = global::Leveldb.Filterpolicy.__CreateInstance(__ret);
            return __result0;
        }

        public static global::Leveldb.Readoptions ReadoptionsCreate()
        {
            var __ret = __Internal.LeveldbReadoptionsCreate();
            global::Leveldb.Readoptions __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::Leveldb.Readoptions.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::Leveldb.Readoptions)global::Leveldb.Readoptions.NativeToManagedMap[__ret];
            else __result0 = global::Leveldb.Readoptions.__CreateInstance(__ret);
            return __result0;
        }

        public static void ReadoptionsDestroy(global::Leveldb.Readoptions _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbReadoptionsDestroy(__arg0);
        }

        public static void ReadoptionsSetVerifyChecksums(global::Leveldb.Readoptions _0, byte _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbReadoptionsSetVerifyChecksums(__arg0, _1);
        }

        public static void ReadoptionsSetFillCache(global::Leveldb.Readoptions _0, byte _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbReadoptionsSetFillCache(__arg0, _1);
        }

        public static void ReadoptionsSetSnapshot(global::Leveldb.Readoptions _0, global::Leveldb.Snapshot _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            var __arg1 = ReferenceEquals(_1, null) ? global::System.IntPtr.Zero : _1.__Instance;
            __Internal.LeveldbReadoptionsSetSnapshot(__arg0, __arg1);
        }

        public static global::Leveldb.Writeoptions WriteoptionsCreate()
        {
            var __ret = __Internal.LeveldbWriteoptionsCreate();
            global::Leveldb.Writeoptions __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::Leveldb.Writeoptions.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::Leveldb.Writeoptions)global::Leveldb.Writeoptions.NativeToManagedMap[__ret];
            else __result0 = global::Leveldb.Writeoptions.__CreateInstance(__ret);
            return __result0;
        }

        public static void WriteoptionsDestroy(global::Leveldb.Writeoptions _0)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbWriteoptionsDestroy(__arg0);
        }

        public static void WriteoptionsSetSync(global::Leveldb.Writeoptions _0, byte _1)
        {
            var __arg0 = ReferenceEquals(_0, null) ? global::System.IntPtr.Zero : _0.__Instance;
            __Internal.LeveldbWriteoptionsSetSync(__arg0, _1);
        }

        public static global::Leveldb.Cache CacheCreateLru(ulong capacity)
        {
            var __ret = __Internal.LeveldbCacheCreateLru(capacity);
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
            __Internal.LeveldbCacheDestroy(__arg0);
        }

        public static global::Leveldb.Env CreateDefaultEnv()
        {
            var __ret = __Internal.LeveldbCreateDefaultEnv();
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
            __Internal.LeveldbEnvDestroy(__arg0);
        }

        public static void Free(global::System.IntPtr ptr)
        {
            __Internal.LeveldbFree(ptr);
        }

        public static int MajorVersion()
        {
            var __ret = __Internal.LeveldbMajorVersion();
            return __ret;
        }

        public static int MinorVersion()
        {
            var __ret = __Internal.LeveldbMinorVersion();
            return __ret;
        }
    }

    namespace LeveldbDelegates
    {
        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public unsafe delegate void Action_IntPtr_string_ulong_string_ulong(global::System.IntPtr _0, [MarshalAs(UnmanagedType.LPStr)] string _1, ulong _2, [MarshalAs(UnmanagedType.LPStr)] string _3, ulong _4);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public unsafe delegate void Action_IntPtr_string_ulong(global::System.IntPtr _0, [MarshalAs(UnmanagedType.LPStr)] string _1, ulong _2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public unsafe delegate void Action_IntPtr(global::System.IntPtr _0);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public unsafe delegate int Func_int_IntPtr_string_ulong_string_ulong(global::System.IntPtr _0, [MarshalAs(UnmanagedType.LPStr)] string _1, ulong _2, [MarshalAs(UnmanagedType.LPStr)] string _3, ulong _4);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public unsafe delegate global::System.IntPtr Func_IntPtr_IntPtr(global::System.IntPtr _0);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public unsafe delegate sbyte* Func_sbytePtr_IntPtr_sbytePtrPtr_ulongPtr_int_ulongPtr(global::System.IntPtr _0, sbyte** _1, ulong* _2, int _3, ulong* _4);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public unsafe delegate byte Func_byte_IntPtr_string_ulong_string_ulong(global::System.IntPtr _0, [MarshalAs(UnmanagedType.LPStr)] string _1, ulong _2, [MarshalAs(UnmanagedType.LPStr)] string _3, ulong _4);
    }
}
