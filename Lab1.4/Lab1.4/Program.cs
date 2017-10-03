using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.4.a)
            //1.4.b)
            Console.WriteLine("1.4.a)");
            Console.WriteLine("1.4.b)");
            var Cortag = (first: 27, second: "String", third: 'S', fourth: "String2", 660);
            Console.WriteLine();

            //1.4.c)
            Console.WriteLine("1.4.c)");
            Console.WriteLine("Кортеж целиком:");
            Console.WriteLine($" {Cortag}");
            Console.WriteLine("1-й, 3-й и 4-й эл-ты кортежа: {0}, {1}, {2}", Cortag.first, Cortag.third, Cortag.fourth);
            Console.WriteLine();

            //1.4.d
            Console.WriteLine("1.4.d)");
            var (one, two, three, four, five) = (Cortag);
            Console.WriteLine("Распакованный кортеж: {0}, {1}, {2}, {3}, {4}", one, two, three, four, five);
            Console.WriteLine();

            //1.4.e
            Console.WriteLine("1.4.e)");
            var CortagToCheck = (first: 27, second: "String", third: 'S', fourth: "String2", 660);
            var CortagToCompare = (first: 27, second: "FirstString", third: 'S', fourth: "SecondString2", 660);
            Console.WriteLine("Сравнение двух кортежей:");
            Console.WriteLine($" {Cortag}");
            Console.WriteLine($" {CortagToCompare}");
            Console.WriteLine("Результат: {0}", Cortag.Equals(CortagToCompare));
            //---------------------------------------------------------------------------------------------
            Console.WriteLine("Сравнение двух кортежей:");
            Console.WriteLine($" {Cortag}");
            Console.WriteLine($" {CortagToCheck}");
            Console.WriteLine("Результат: {0}", Cortag.Equals(CortagToCheck));
            Console.WriteLine();
        }
    }
}