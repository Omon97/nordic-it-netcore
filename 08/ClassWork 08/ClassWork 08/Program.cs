using System;
using System.Collections.Generic;

namespace ClassWork_08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();


            do
            {
                Console.WriteLine("Введите числовое значение");
                string input = Console.ReadLine();
                if (input == "stop")
                    break;
                double number = double.Parse(input);
                list.Add(number);

                try
                {
                    list.Add(item: double.Parse(input));
                }

                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Вводите только числовое значение");
                    throw;
                }

                
            } while (true);
            


        }
    }
}
