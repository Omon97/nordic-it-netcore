using System;
using System.Collections.Generic;

namespace ClassWork_08__3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<double> numbers = new Queue<double>();

            Console.WriteLine("Введите числа для вычисления его квадратного корня, run для расчёта или exit.");

            while (true)
            {
               
                string input = Console.ReadLine();

                if (input == "exit")
                {
                    Console.WriteLine(numbers.Count);
                    break;
                }

                if (input == "run")
                {
                    while(numbers.Count > 0)
                    {
                        double n = numbers.Dequeue();
                        Console.WriteLine($"{Math.Sqrt(n)}");                        
                    }
                    continue;
                }

                numbers.Enqueue(double.Parse(input));
            }
        }
    }
}
