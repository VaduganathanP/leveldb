using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Leveldb
{
    public static class MarshalHelper
    {
        public unsafe static byte* ByteArrayToBytePtr(byte[] @in)
        {
            fixed (byte* _ret = @in)
            {
                return _ret;
            }
        }

        public unsafe static byte** ByteArrayToBytePtrArray(byte[] @in)
        {
            fixed (byte* _ret0 = @in)
            {
                byte*[] _ret1 = { _ret0 };
                fixed (byte** _ret = _ret1)
                {
                    return _ret;
                }
            }
        }

        public unsafe static sbyte* SByteArrayToSbytePtr(sbyte[] @in)
        {
            fixed (sbyte* _ret = @in)
            {
                return _ret;
            }
        }

        public unsafe static sbyte** SByteArrayToSbytePtrArray(sbyte[] @in)
        {
            fixed (sbyte* _ret0 = @in)
            {
                sbyte*[] _ret1 = { _ret0 };
                fixed (sbyte** _ret = _ret1)
                {
                    return _ret;
                }
            }
        }

        public static byte[] IntPtrToByteArray(IntPtr @int, int length)
        {
            byte[] bytes = new byte[length];
            Marshal.Copy(@int, bytes, 0, length);
            Leveldb.Native.Utility.Free(@int);
            return bytes;
        }
    }
}
