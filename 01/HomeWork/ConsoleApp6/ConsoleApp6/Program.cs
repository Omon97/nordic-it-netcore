using System;
using System.Threading;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            String name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine($"Здравствуйте, {name}!");
            Thread.Sleep(5000);
            Console.WriteLine($"Досвидания, {name}!");
            Console.ReadKey();
        }
    }
}
