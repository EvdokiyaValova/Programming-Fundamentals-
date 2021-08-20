using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double countP1 = 0;
            double countP2 = 0;
            double countP3  = 0;

            for (int i = 1; i <= n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber % 2 == 0)
                {
                    countP1++;
                }

                if (currentNumber % 3 == 0)
                {
                    countP2++;
                }

                if (currentNumber % 4 == 0)
                {
                    countP3++;
                }
            }

            double p1 = countP1 / n * 100;
            double p2 = countP2 / n * 100;
            double p3 = countP3 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");

        }
    }
}
