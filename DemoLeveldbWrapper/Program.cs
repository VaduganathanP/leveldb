using Leveldb;
using System;
using System.IO;
using System.Reflection;

namespace DemoLeveldbWrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                unsafe
                {
                    fixed (sbyte* errptr1 = new sbyte[] { })
                    {
                        sbyte*[] errptr2 = { errptr1 };
                        fixed (sbyte** errptr = errptr2)
                        {
                            Options options = NLDB.OptionsCreate();
                            NLDB.OptionsSetCreateIfMissing(options, 1);
                            NLDB.OptionsSetCompression(options, 1);
                            string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                            string dbPath = Path.Combine(assemblyPath, "DbFiles");
                            if (!Directory.Exists(dbPath))
                                Directory.CreateDirectory(dbPath);

                            DB leveldb = NLDB.Open(options, dbPath, errptr);

                            NLDB.Put(leveldb, NLDB.WriteoptionsCreate(), "TempKey", (ulong)"TempKey".Length, "TempVal", (ulong)"TempVal".Length, errptr);
                            ulong vallen = 0;
                            var resultVal = NLDB.Get(leveldb, NLDB.ReadoptionsCreate(), "Hi", (ulong)"Hi".Length, ref vallen, errptr);

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
