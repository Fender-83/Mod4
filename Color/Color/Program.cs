using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name?");
            var name = Console.ReadLine();
            Console.WriteLine(" Write lastname:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Ваше имя по буквам");

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i] + " ");
            }
            Console.WriteLine("последняя буква");
            int lastCharOfName = name.Length -1;
            int firstIndex = 0;
            Console.WriteLine("Первая буква имени" + name[firstIndex] );
            int lastCharOfLasetName = lastName.Length - 1;
            Console.WriteLine(name[lastCharOfName]);

            foreach (var item in lastName)
            {
                Console.Write(item + " ");
            }
            int LastIndex = lastName.Length - 1;
            Console.WriteLine();
            Console.WriteLine(lastName[LastIndex]);
           

        } 
    }
}