using System;

namespace Top_Number2
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int number = Math.Abs(inputNumber);

            for (int i = 1; i <= number; i++)
            {
                int sumDigit = 0;
                int currentNumber = i;
                int counterOddDigit = 0;
                while (currentNumber > 0)
                {
                    int currentDigit = currentNumber % 10;
                    sumDigit += currentDigit;                    

                    if (currentDigit % 2 != 0)
                    {
                        counterOddDigit++;
                    }
                    currentNumber /= 10;
                }

                bool isOddDigit = false;

                if (counterOddDigit > 0)
                {
                    isOddDigit = true;
                }
                else
                {
                    isOddDigit = false;
                }
                bool isDivisibleBy8 = false;
                if (sumDigit % 8 == 0)
                {
                    isDivisibleBy8 = true;                    
                }
                else
                {
                    isDivisibleBy8 = false;                   
                }

                if (isDivisibleBy8 == true && isOddDigit == true && inputNumber >= 0)
                {
                    Console.WriteLine(i);
                }
                else if (isDivisibleBy8 == true && isOddDigit == true && inputNumber <= 0)
                {
                    Console.WriteLine($"-{i}");
                }
            }
        }

    }
}

