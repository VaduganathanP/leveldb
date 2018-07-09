using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Leveldb
{
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
