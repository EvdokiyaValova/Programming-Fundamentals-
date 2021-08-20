using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            int[] roundedArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = 0;
                }
                roundedArr[i] = (int)Math.Round(arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{arr[i]} => {roundedArr[i]}");
            }
        }
    }
}

