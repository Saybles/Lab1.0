using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.ValueTuple;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            /* sbyte sbyte1 = 17;
             byte byte1 = 211Install-Package «System.ValueTuple» -IncludePrerelease
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
             decimal decimal1 = 67438635827835;*/

            // Объявляем двумерный массив
            //int n = 5;
            //int m = 6;
            //3.


            int[,] Arr1 = new int[5, 7];
            Random ran1 = new Random();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Arr1[i, j] = ran1.Next(-99, 99);
                    Console.Write("{0}\t", Arr1[i, j]);
                }
                Console.WriteLine();
            }

            String[] Arr2 = new String[19];

            Console.Write("Введите массив строк:\n");
            for (int i = 0; ; i++)
            {
                Arr2[i] = Console.ReadLine();
                if (Arr2[i] == "000")
                {
                    break;
                }
            }

            int Arr2Lenght = 0;

            for (int i = 0; i < 19; i++)
            {
                if (Arr2[i] != null & Arr2[i] != "000")
                {
                    Console.Write("{0}\t", Arr2[i]);
                    Console.WriteLine();
                    Arr2Lenght++;
                }
            }

            Console.Write("Длина массива - {0} элементов\n", Arr2Lenght);
            Console.Write("Введите номер элемента, который нужно поменять:\n");

            int NomToChange;
            String NewChange;

            NomToChange = Int32.Parse(Console.ReadLine());

            Console.Write("Введите его новое значение:\n");
            NewChange = Console.ReadLine();

            Arr2[NomToChange - 1] = NewChange;

            Console.Write("Измененный массив:\n");

            for (int i = 0; i < 19; i++)
            {
                if (Arr2[i] != null & Arr2[i] != "000")
                {
                    Console.Write("{0}\t", Arr2[i]);
                    Console.WriteLine();
                }
            }

            double[][] Arr3 = new double[3][];
            Arr3[0] = new double[2];
            Arr3[1] = new double[3];
            Arr3[2] = new double[4];

            for (int i = 0, n = 2; i < 3; i++, n++)
            {
                for (int i2 = 0; i2 < n; i2++)
                {
                    Arr3[i][i2] = Int32.Parse(Console.ReadLine());
                    //Console.Write("{0}\t", Arr3[i][i2]);
                }
                Console.WriteLine();
            }

            for (int i = 0, n = 2; i < 3; i++, n++)
            {
                for (int i2 = 0; i2 < n; i2++)
                {
                    // Arr3[i][i2] = Int32.Parse(Console.ReadLine());
                    Console.Write("{0}\t", Arr3[i][i2]);
                }
                Console.WriteLine();
            }

            var VarArray = new[] { 1, 2, 3, 4, 5, 6 };
            var VarString = "ThisIsString";


            ValueTuple<string, int> student = (name:"Olga", 19);
            (string, string, int) namesAndAge = ("Olga", "Krol", 22);

            var names = (first: "Никита", second: "Грицевич");
            string firstName = names.first;
            string secondName = names.second;

        }
    }
}
