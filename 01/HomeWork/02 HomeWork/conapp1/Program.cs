using System;

namespace conapp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstNumber, secondNumber;
                string calculation;

                try
                {
                    Console.WriteLine("Enter number 1");
                    firstNumber = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter number 2");
                    secondNumber = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You must enter only numbers!");
                    Console.ReadLine();
                    continue;
                }

               

                Console.WriteLine("Choose calculation:'+' '-' '*' '/' '^' '%' (For division with remainder)");
                calculation = Console.ReadLine();

                if (calculation == "+")
                {
                    Console.WriteLine(firstNumber + secondNumber);
                }
                else if (calculation == "-")
                {
                    Console.WriteLine(firstNumber - secondNumber);
                }
                else if (calculation == "*")
                {
                    Console.WriteLine(firstNumber * secondNumber);
                }
                else if (calculation == "/")
                {
                    if (secondNumber == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine(firstNumber / secondNumber);
                }
                else if (calculation == "%")
                {
                    Console.WriteLine(firstNumber % secondNumber);
                }
                else if (calculation == "^")
                {
                    Console.WriteLine(Math.Pow(firstNumber, secondNumber));
                }
                else
                {
                    Console.WriteLine("You must choose calculation!");
                }
                Console.ReadLine();
            }
        }
    }
}
