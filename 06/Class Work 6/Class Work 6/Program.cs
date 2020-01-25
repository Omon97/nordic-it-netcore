using System;
using System.Threading;

namespace Class_Work_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var marks = new []
            {
                new [] {2, 3, 3, 2, 3 }, // Monday (it was a good weekend :)
                new [] {2, 4, 5, 3 },   // Tuesday (anyway better than Monday)
                null,                    // Wednesday (felt sick, stayed at home :(
                new [] {5, 5, 5, 5 },    // Thursday (God mode :)
                new [] {4}              // Friday (a very short day)
            };
            int marksCount = 0;
            int totalSum = 0;
            for (int j = 0; j < marks.Length; j++)
            {
                int sum = 0;
                if(marks[j] == null)
                {
                    Console.WriteLine("N/A");
                    continue;
                }

                for (int i = 0; i < marks[j].Length; i++)
                {
                    sum = sum + marks[j][i];
                    totalSum = totalSum + marks[j][i];
                    marksCount++;
                }

                Console.WriteLine((float)sum / marks[j].Length);                
            }

            Console.WriteLine((float)totalSum / marksCount);

        }


    }
}
