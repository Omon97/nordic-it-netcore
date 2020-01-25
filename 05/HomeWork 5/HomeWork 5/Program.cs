using System;

namespace HomeWork_5
{
	class Program
	{
        static void Main(string[] args)
        
		{
            double index = 0;
            //считываем ввод
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Choose your figure \n 1. Circle \n 2. EquilateralTriangle \n 3. Rectangle");
                    index = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You must enter only numbers! Please, press Enter to restart");
                    Console.ReadLine();
                    continue;
                }
                if (index == 1)
                {
                    //если выбрали Circle
                    string a;
                    Console.Write("Enter the Diameter of circle:");
                    a = Console.ReadLine();
                    double c;
                    double.TryParse(a, out c);
                    if (c == 0)
                    {
                        Console.WriteLine("Please, write only numbers. Press Enter to restart the program");
                        Console.ReadLine();
                    }
                    else
                    {
                        double AreaC = Math.PI * Math.Pow((c / 2), 2);
                        double PerimeterC = Math.PI * c;
                        Console.WriteLine("The Area of Circle:" + Math.Round(AreaC)+ "\nThe Perimeter of Circle:" + Math.Round(PerimeterC));
                        Console.ReadLine();
                    }
                    
                }
                else if (index == 2)
                {
                    //если выбрали Triangle
                    string b;
                    Console.Write("Enter the side of EquilateralTriangle:");
                    b = Console.ReadLine();
                    double t;
                    double.TryParse(b, out t);
                    if(t == 0)
                    {
                        Console.WriteLine("Please, write only numbers. Press Enter to restart the program");
                        Console.ReadLine();
                    }
                    else
                    {
                        double AreaT = (Math.Pow(t, 2) * Math.Sqrt(3)) / 4;
                        double PerimeterT = 3 * t;
                        Console.WriteLine("\nThe Area of Triangle:" + Math.Round(AreaT) + "\nThe Perimeter of Triangle:" + Math.Round(PerimeterT) + "\nPress Enter to restart the program");
                        Console.ReadLine();
                    }
                    
                }
                else if (index == 3)
                {
                    //если выбрали Rectangle
                    string c;
                    Console.Write("Enter the width of Rectangle:");
                    c = Console.ReadLine();
                    double r;
                    double.TryParse(c, out r);
                    //
                    string e;
                    Console.Write("Enter the height of Rectangle:");
                    e = Console.ReadLine();
                    double r2;
                    double.TryParse(e, out r2);
                    //
                    if (r == 0 || r2 == 0)
                    {
                        Console.WriteLine("Please, write only numbers. Press Enter to restart the program");
                        Console.ReadLine();
                    }
                    else
                    {
                        double AreaR = r * r2;
                        double PerimeterR = (r + r2) * 2;
                        Console.WriteLine("\nThe Area of Triangle:" + Math.Round(AreaR) + "\nThe Perimeter of Triangle:" + Math.Round(PerimeterR) + "\nPress Enter to restart the program");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Unnamed command");
                    Console.ReadLine();
                }
            }
        }
	}
}
