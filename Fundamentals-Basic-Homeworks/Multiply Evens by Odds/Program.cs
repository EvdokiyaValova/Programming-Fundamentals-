using System;
using System.Linq;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int currentNumber = Math.Abs(number);

            int evenSum = 0;   
            int oddSum = 0;   

            while (currentNumber > 0)
            {
                int curentDigit = currentNumber % 10;

                if (curentDigit % 2 == 0)
                {
                    evenSum += curentDigit;
                }
                else
                {
                    oddSum += curentDigit;
                }                    

                currentNumber /= 10;
            }


            int result = MultiplyEvenSumByOddSum(evenSum, oddSum);

            Console.WriteLine(result);
        }

         static int MultiplyEvenSumByOddSum(int evenSum, int oddSum)
        {
            int multiplay = evenSum * oddSum;
            return multiplay;
        }
    }
}

