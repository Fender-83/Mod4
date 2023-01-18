using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Имя?");
            var name = Console.ReadLine();
            for (int i = name.Length-1; i >=0; i--)
            { 
                Console.Write(name[i]);
            }
            Console.WriteLine();

            char[] nameReverse = new char[name.Length];
            for (int i = 0,  j =name.Length-1; i < name.Length && j>=0; i++, j--)
            {
                Console.WriteLine("i= "+i + " j= " + j);

                nameReverse[i] = name[j];
            }
            Console.WriteLine("Имя наоборот");

            foreach (var item in nameReverse)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("Имя прямо");
            foreach (var item in name)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Example index ++ & --");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            for (int i = 10; i >= 0; i--)
            {
                Console.Write(i+" ");
            }

        }
    }
}
