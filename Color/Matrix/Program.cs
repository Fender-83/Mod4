using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arrey = new int[2, 3] { { 1, 2, 3 }, { 5, 6, 7 } };

            foreach (int i in arrey)
            {
                Console.Write((i) + " ");
            }
            Console.WriteLine();
            Console.WriteLine(arrey.Length);
            Console.WriteLine("Последний индекс нулевой размерности(строк) " + arrey.GetUpperBound(0));
            Console.WriteLine("Последний индекс первой размерности(столбцов) " + arrey.GetUpperBound(1));

            int lastIndexRow = arrey.GetUpperBound(0);
            int lastIndexColumn = arrey.GetUpperBound(1);

            for (int i = 0; i <= lastIndexRow; i++)// <= потому что это последний индекс а не длина
            {
                for (int j = 0; j <= lastIndexColumn; j++)
                {
                    Console.Write(arrey[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i != j && i!=j+2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // Name, LastName, City
            string[,] personData = new string[2, 3] { { "Artem", "Aksenov", "Dortmund" }, { "Fedor", "Pugach", "Abakan" } };
        }
    }
}
