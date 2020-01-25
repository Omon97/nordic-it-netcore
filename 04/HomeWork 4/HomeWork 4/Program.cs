using System;

namespace HomeWork_4
{
	class Program
	{
		static void Main(string[] args)
		{
			[Flags]
			enum Liters
			{
				Small = 2,
				Medium = 5,
				Large = 20
			}
			
			try
			{
				Console.WriteLine("How much juice in liters should we pack?");
				juiceLitres = double.Parse(Console.ReadLine());
			}
			catch (Exception)
			{
				Console.WriteLine("You must enter only numbers!");
				Console.ReadLine();
			}
			
		}
	 }	
	

