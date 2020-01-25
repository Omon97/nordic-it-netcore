using System;

namespace ClassWork_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("Enter first value:");
            a = Console.ReadLine();
            double c;
            double.TryParse(a, out c);
            
            Console.WriteLine("Enter second value:");
            a = Console.ReadLine();
            double d;
            double.TryParse(a, out d);
            double sum = c * d;
            string result1 = c + " * " + d + " = " + sum;
            Console.WriteLine(result1);
            string result2 = String.Format("{0:#.##} + {1:#.##} = {2}", c, d, sum);
            Console.WriteLine(result2);
            string result3 = $"{c} - {d} = {sum}";
            Console.WriteLine(result3);
        }
    }
}
