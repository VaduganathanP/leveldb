using Leveldb;
using Leveldb.Native;
using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace DemoLeveldbWrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();
            Console.ReadLine();
        }

       static void Init()
        {
            try
            {
                byte[] resultVal;
                sbyte[] err = new sbyte[] { };
                string tempKey = "TempKey";
                string tempValue = "TempValue";

                using (DB db = new DB(err))
                {
                    db.Put(tempKey, tempValue, err);
                    ulong vallen = 0;
                    resultVal = db.Get(tempKey, ref vallen, err);
                    db.Delete(tempKey, err);
                }
                

                string retStr = Encoding.UTF8.GetString(resultVal);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
