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
            //1.3.a)
            Console.Write("1.3.a)\n");
            Console.Write("Целый двумерный массив, отформатированный:");
            Console.WriteLine();
            int[,] Arr1 = new int[5, 7];
            Random ran1 = new Random();
            //----------------------------------------------------------------------------------
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Arr1[i, j] = ran1.Next(-99, 99);
                    Console.Write("{0}\t", Arr1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //1.3.b)
            Console.Write("1.3.b)\n");
            String[] Arr2 = new String[19];
            //----------------------------------------------------------------------------------
            Console.Write("Введите массив строк:\n");
            for (int i = 0; ; i++)
            {
                Arr2[i] = Console.ReadLine();
                if (Arr2[i] == "000")
                {
                    break;
                }
            }
            Console.WriteLine();
            //----------------------------------------------------------------------------------
            int Arr2Lenght = 0;
            //----------------------------------------------------------------------------------
            for (int i = 0; i < 19; i++)
            {
                if (Arr2[i] != null & Arr2[i] != "000")
                {
                    Console.Write("{0}\t", Arr2[i]);
                    Console.WriteLine();
                    Arr2Lenght++;
                }
            }
            Console.WriteLine();
            //----------------------------------------------------------------------------------
            Console.Write("Длина массива - {0} элементов\n", Arr2Lenght);
            Console.Write("Введите номер элемента, который нужно поменять:\n");
            //----------------------------------------------------------------------------------
            int NomToChange;
            String NewChange;
            NomToChange = Int32.Parse(Console.ReadLine());
            //----------------------------------------------------------------------------------
            Console.Write("Введите его новое значение:\n");
            NewChange = Console.ReadLine();

            Arr2[NomToChange - 1] = NewChange;
            Console.WriteLine();
            //----------------------------------------------------------------------------------
            Console.Write("Измененный массив:\n");

            for (int i = 0; i < 19; i++)
            {
                if (Arr2[i] != null & Arr2[i] != "000")
                {
                    Console.Write("{0}\t", Arr2[i]);
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            //1.3.c)
            Console.Write("1.3.c)\n");

            double[][] Arr3 = new double[3][];
            Arr3[0] = new double[2];
            Arr3[1] = new double[3];
            Arr3[2] = new double[4];
            //----------------------------------------------------------------------------------
            Console.Write("Введите ступенчатый массив:\n");
            for (int i = 0, n = 2; i < 3; i++, n++)
            {
                for (int i2 = 0; i2 < n; i2++)
                {
                    Arr3[i][i2] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            //----------------------------------------------------------------------------------
            Console.Write("Массив:\n");
            for (int i = 0, n = 2; i < 3; i++, n++)
            {
                for (int i2 = 0; i2 < n; i2++)
                {
                    Console.Write("{0}\t", Arr3[i][i2]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //1.3.d)
            Console.Write("1.3.d)\n");
            var VarArray = new[] { 1, 2, 3, 4, 5, 6 };
            var VarString = "ThisIsString";
            Console.Write("Строка заданная через неявную типизацию переменной: {0}\t", VarString);
            Console.WriteLine();
        }
    }
}
