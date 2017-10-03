using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.5
            Int32[] Arr1 = { 1, -9, 4, 7, -5, -5, 11, 16 };
            String Str1 = "ThisIsString";

            (int, int, double, char) LocalFunc(Int32[] Arr, String Str)
            {
                int min = Arr[0];
                int max = Arr[0];
                double sum = 0;
                foreach(int element in Arr)
                {
                    min = element < min ? element : min;
                    max = element > max ? element : max;
                    sum += element;
                }
                return (max, min, sum, Str[0]);
            }
            
            Console.WriteLine("Кортеж, как результат локальной функции: {0}", LocalFunc(Arr1, Str1));

        }
    }
}