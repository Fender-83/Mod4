using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Анкета
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] data = new string[5, 3];

            for (i = 0; i < 5; i++);
            {
                for (j = 0; J < 3; j++);
                {
                    switch (data); 

                        case 0: 
                        Console.WriteLine("Имя");
                    Console.ReadLine();
                    break;

                        case 1:
                        Console.WriteLine("Фамилия");
                    Console.ReadLine();
                    break;

                        case 2:
                        Console.WriteLine("Год рождения");
                    Console.ReadLine();
                    break;
                }
                data[i,j] = Console.ReadLine();
            }
        }
    }
}
