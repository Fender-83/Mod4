using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kortezhy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string [] Dishes) User; // Кортеж User с массивом Dishes

            Console.WriteLine("Введите имя пользователя");
            User.Name = Console.ReadLine();


            User.Dishes = new string[5]; // Объявление размерности массива - 5 (любимых блюд)

            for (int i = 0; i < User.Dishes.Length; i++) // Заполняем по циклу наименование любимых блюд по очереди
            {
                Console.WriteLine("Введите любимое блюдо {0}", i + 1); // Вывод на экран
                User.Dishes[i] = Console.ReadLine();
            }

            Console.WriteLine();
        }
    }
}
