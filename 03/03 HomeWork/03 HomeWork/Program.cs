using System;

namespace HomeWork_3
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter the second name: ");
            string secondName = Console.ReadLine();

            Console.Write("Enter the third name: ");
            string thirdName = Console.ReadLine();

            Console.Write("Enter the age of the first person: ");
            int firstAge = int.Parse(Console.ReadLine());

            Console.Write("Enter the age of the second person: ");
            int secondtAge = int.Parse(Console.ReadLine());

            Console.Write("Enter the age of the third person: ");
            int thirdAge = int.Parse(Console.ReadLine());

            string[] names = new string[3];

            names[0] = firstName;
            names[1] = secondName;
            names[2] = thirdName;


            int[] ages =
            {
                firstAge + 4,
                secondtAge + 4,
                thirdAge + 4,
            };

            for (int i = 0; i < names.Length && i < ages.Length; i++)
            {
                Console.WriteLine("Name: " + names[i] + " age in 4 years: " + ages[i]);
            }
                Console.ReadLine();
        }
	}
}
