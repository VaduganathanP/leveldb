using System;
using System.Collections.Generic;
using System.Text;

namespace Leveldb
{
    public enum CompressionType : byte
    {
        LeveldbNoCompression = 0,
        LeveldbSnappyCompression = 1
    }
}
