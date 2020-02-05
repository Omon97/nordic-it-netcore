using System;
using System.Diagnostics;

namespace ClassWork_09
{
    class Program
    {
        static void Main(string[] args)
        {
            const int length = 50000;
            const int maxValue = 1_000_000;

            int[] arr = GetInitialArray(length, maxValue);
            WriteOutArray(arr, arrayName: "Initial array:");

            Stopwatch timer = new Stopwatch();
            timer.Start();
            int[] bubbleArray = GetBubbleSortedArray(arr);
            timer.Stop();
            WriteOutArray(bubbleArray, arrayName: $"Buuble-sorted array({timer.ElapsedMilliseconds}) ms");

            timer.Restart();
            int[] netCoreArray = GetNetcoreSortedArray(arr);
            timer.Stop();
            WriteOutArray(netCoreArray, arrayName: $"Buuble-sorted array({timer.ElapsedMilliseconds}) ms");

            WriteOutArray(arr, arrayName: "Initial array:");
        }

        static int[] GetInitialArray(int lenght, int maxValue)
        {
            var arr = new int[lenght];
            var rnd = new Random();
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(maxValue);
            }

            return arr;
        }

        static void WriteOutArray(int[] arr, string arrayName)
        {
            Console.WriteLine(arrayName);
            //for (var i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
        }

        static int[] GetBubbleSortedArray(int[] array)
        {
            int[] arr = (int[])array.Clone();
            for (var w = 0; w < arr.Length - 1; w++)
            {
                for (var i = 0; i < arr.Length - 1 - w; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        //int temp = arr[i];
                        //arr[i] = arr[i + 1];
                        //arr[i + 1] = temp;

                        arr[i] = arr[i] ^ arr[i + 1];
                        arr[i + 1] = arr[i + 1] ^ arr[i];
                        arr[i] = arr[i] ^ arr[i + 1];
                    }
                }
            }

            return arr;
        }

        static int[] GetNetcoreSortedArray(int[] array)
        {
            int[] arr = (int[])array.Clone();
            Array.Sort(arr);
            return arr;
        }
    }
}
