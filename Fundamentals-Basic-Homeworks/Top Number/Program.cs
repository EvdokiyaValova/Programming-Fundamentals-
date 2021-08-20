using System;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int n = Math.Abs(number);

            for (int i = 1; i <= n; i++)
            {
                int currentNumber = i;
                int sumDigits = 0;
                int counterOddDigit = 0;

                while (currentNumber % 10 > 0)
                {
                    int currentDigit = currentNumber % 10;
                    counterOddDigit = IsOddDigit(counterOddDigit, currentDigit);
                    sumDigits += currentDigit;
                    currentNumber /= 10;
                }

                bool isDivisible = IsDivisible(sumDigits);

                IsTopNumber(i, counterOddDigit, isDivisible, number);
            }
        }

        private static int IsOddDigit(int counterOddDigit, int currentDigit)
        {
            if (currentDigit % 2 == 1)
            {
                counterOddDigit++;
            }

            return counterOddDigit;
        }

        private static void IsTopNumber(int i, int counterOddDigit, bool isDivisible , int number)
        {
            if (isDivisible == true && counterOddDigit > 0)
            {
                if (number >= 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine($"-{i}");
                }
                
            }
        }

        private static bool IsDivisible(int sumDigits)
        {
            bool isDivisible = false;
            if (sumDigits % 8 == 0)
            {
                isDivisible = true;
                return true;
            }
            else
            {
                isDivisible = false;
                return false;
            }            
        }
    }
}
