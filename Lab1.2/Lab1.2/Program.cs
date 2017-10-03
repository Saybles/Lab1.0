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
            //1.2.a)
            Console.Write("1.2.a)\n");
            string Lit1 = "Literal№1";
            string Lit2 = "Literal№2";
            Console.Write("Сравнение строк \"{0}\" и \"{1}\" по кодировке:\n", Lit1, Lit2);
            if (Lit1 == Lit2)
            {
                Console.WriteLine("Cтрока \"{0}\" равна строке \"{1}\"", Lit1, Lit2);
            } else
            {
                Console.WriteLine("Cтрока \"{0}\" не равна строке \"{1}\"", Lit1, Lit2);
            }
            Console.WriteLine();

            //1.2.b)
            Console.Write("1.2.b)\n");
            String ForB1 = "First String For Testing";
            String ForB2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String ForB3 = "This Is Second String To Try Somesing";
            String Result;
            String[] ResultArr;
            String SubForB = "SomeSubstring";
            int PosToCopy;
            String ToRemoveFrom;
            int PosToRemove; 
            //----------------------------------------------------------------------------------
            Console.Write("Исходные строки: \"{0}\", \"{1}\", \"{2}\":\n", ForB1, ForB2, ForB3);
            Console.WriteLine();
            //----------------------------------------------------------------------------------
            Console.Write("Сцепление строк в порядке(1 + 3 + 2):\n", ForB1, ForB2, ForB3);
            Result = ForB1 + ForB3 + ForB2;
            Console.WriteLine("{0}", Result);
            Console.WriteLine();
            //-----------------------------------------------------------------------------------
            Console.Write("Разделение строк 1 и 3 на слова:\n");
            ResultArr = ForB1.Split(' ');
            foreach (String Word in ResultArr)
            {
                Console.WriteLine(Word);
            }
            Console.WriteLine();
            ResultArr = ForB3.Split(' ');
            foreach (String Word in ResultArr)
            {
                Console.WriteLine(Word);
            }
            Console.WriteLine();
            //-----------------------------------------------------------------------------------
            Console.Write("Копирование строки 2 в строку Result:\n");
            Result = String.Copy(ForB2);
            Console.WriteLine("После копирования:");
            Console.WriteLine("2 = \"{0}\", Result =  \"{1}\"", ForB2, Result);
            Console.WriteLine("Сравнение по ссылке(ReferenceEquals): {0}", Object.ReferenceEquals(ForB2, Result));
            Console.WriteLine("Сравнение по значению(Equals): {0}", Object.Equals(ForB2, Result));
            Console.WriteLine();
            //-----------------------------------------------------------------------------------
            Console.Write("Выделение подстроки длиной 7 с позиции 4 в исходных строках:\n");
            Result = ForB1.Substring(3, 7);
            Console.WriteLine("{0}", Result);
            Result = ForB2.Substring(3, 7);
            Console.WriteLine("{0}", Result);
            Result = ForB3.Substring(3, 7);
            Console.WriteLine("{0}", Result);
            Console.WriteLine();
            //-----------------------------------------------------------------------------------
            Console.Write("Вставка подстроки \"{0}\" в заданную позицию исходных строк:\n", SubForB);
            Console.WriteLine("Введите позицию:");
            PosToCopy = Int32.Parse(Console.ReadLine());
            Result = ForB1.Insert(PosToCopy - 1, SubForB);
            Console.WriteLine("{0}", Result);
            Result = ForB2.Insert(PosToCopy - 1, SubForB);
            Console.WriteLine("{0}", Result);
            Result = ForB3.Insert(PosToCopy - 1, SubForB);
            Console.WriteLine("{0}", Result);
            Console.WriteLine();
            //-----------------------------------------------------------------------------------
            Console.Write("Удаление подстроки:\n");
            Console.Write("Введите основную строку:\n");
            ToRemoveFrom = Console.ReadLine();
            Console.Write("Введите позицию для удаления и длину подстроки :\n");
            Result = ToRemoveFrom.Remove(Int32.Parse(Console.ReadLine()) - 1, Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Полученная строка: {0}", Result);
            Console.WriteLine();

            //1.2.c)
            Console.Write("1.2.c)\n");
            string EmptyStr = "";
            string NullStr = null;
            //-----------------------------------------------------------------------------------

            //1.2.d)
            Console.Write("1.2.d)\n");
            StringBuilder SB = new StringBuilder("ABCDEFGIGK", 40);
            Console.WriteLine("Исходня строка: {0}", SB.ToString());
            SB.Remove(2, 1);
            SB.Remove(6, 1);
            SB.Remove(7, 1);
            SB.Insert(0, "Start: ");
            SB.Append("...Finish");
            Console.WriteLine("Результат: {0}", SB.ToString());
            Console.WriteLine();
        }
    }
}
