﻿using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine($"Здравствуйте, {name}!");
            Console.ReadKey();
            Thread.Sleep(5000);
            Console.WriteLine($"До свидания, {name}!");
            Console.ReadKey();
        }
    }
}
