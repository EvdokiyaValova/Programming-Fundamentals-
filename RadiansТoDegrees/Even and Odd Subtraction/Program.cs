using System;
using System.Linq;

namespace Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumEvenNumbers = 0;
            int sumOddNumbers = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % 2 == 0)
                {
                    sumEvenNumbers += inputArray[i];
                }
                else
                {
                    sumOddNumbers += inputArray[i];
                }
            }

            int difference = sumEvenNumbers - sumOddNumbers;

            Console.WriteLine(difference);
        }
    }
}
