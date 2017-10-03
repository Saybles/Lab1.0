using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.1.a)
            sbyte sbyte1 = 17;
            byte byte1 = 211;
            short short1 = 1573;
            ushort ushort1 = 2600;
            int int1 = 99;
            uint uint1 = 3458;
            long long1 = 1542676;
            ulong ulong1 = 3678467;
            char char1 = 's';
            float float1 = 1513;
            double double1 = 7e17;
            bool bool1 = false;
            decimal decimal1 = 67438635827835;

            //1.1.b)
            Int32 i32 = 5;
            Int64 i64 = i32;
            Single s = i32;
            Double db = i64;
            float fl = i64;
            decimal de = i64;
            //----------------------------------------------------------------------------------
            Byte b = (Byte)i32;
            Double db2 = (Double)i32;
            Int16 v = (Int16)s;
            short sh = (short)i32;
            long lo = (long)i64;

            //1.1.c)
            Int32 x = 5;
            Object o = x;
            Int32 x2 = (Int32)o;
            byte bt = (byte)(Int32)o;
            //----------------------------------------------------------------------------------
            double db1 = 5.78;
            Object o2 = db1;
            double db3 = (double)o2;
            float x3 = (float)(double)o2;

            //1.1.d)
            Console.WriteLine("1.1.d\nНеявно типизированная переменная:");
            var myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            foreach (var i in myList)
            {
                Console.WriteLine(i);
            }

            //1.1.e)
            Console.WriteLine("1.1.e\nСравнение(x11 == x22 ?) двух null переменных:");
            int? x11 = null;
            int? x22 = null;
            Console.Write(x11 == x22);
            Console.WriteLine();
        }
    }
}
