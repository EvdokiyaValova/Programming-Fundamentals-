using System;
using System.Linq;

namespace Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumEvenNumbers = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % 2 == 0)
                {
                    sumEvenNumbers += inputArray[i];
                }
            }

            Console.WriteLine(sumEvenNumbers);
        }
    }
}
