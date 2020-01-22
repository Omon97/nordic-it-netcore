using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение а");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение h");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение n");
            double n = double.Parse(Console.ReadLine());

            double v = h * n * Math.Pow (a,2) / (12 * Math.Tan(Math.PI / n));
            Console.WriteLine (v);

            double sp = n * a / 2 * (a / 2 / Math.Tan(Math.PI / n) + Math.Sqrt(Math.Pow(h, 2) + Math.Pow(a / 2 / Math.Tan(Math.PI / n),2)));
            Console.WriteLine(sp);


 
        }
    }
}
