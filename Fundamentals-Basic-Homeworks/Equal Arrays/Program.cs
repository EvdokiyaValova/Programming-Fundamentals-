using System;
using System.Linq;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstInputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondInputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumDigits = 0;
            bool isIdentical = true;
            for (int i = 0; i < firstInputArray.Length; i++)
            {
                if (firstInputArray[i] == secondInputArray[i])
                {
                    sumDigits += firstInputArray[i];
                }
                else
                {
                    isIdentical = false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }

            if (isIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sumDigits}");
            }
        }
    }
}
