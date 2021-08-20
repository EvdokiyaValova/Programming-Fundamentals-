using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            PrintSmallestNumber(firstNumber, secondNumber, thirdNumber);
        }

        private static void PrintSmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int smallestNumber = 0;

            if (firstNumber <= secondNumber && firstNumber <= thirdNumber)
            {
                smallestNumber = firstNumber;
            }
            else if (firstNumber >= secondNumber && secondNumber <= thirdNumber)
            {
                smallestNumber = secondNumber;
            }
            else if (firstNumber >= thirdNumber && secondNumber >= thirdNumber)
            {
                smallestNumber = thirdNumber;
            }
            Console.WriteLine(smallestNumber);
        }

    }
}
