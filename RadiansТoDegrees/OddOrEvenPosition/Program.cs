using System;

namespace OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double evenSum = 0;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double curentNumber = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += curentNumber;

                    if (curentNumber > evenMax)
                    {
                        evenMax = curentNumber;
                    }

                    if (curentNumber < evenMin)
                    {
                        evenMin = curentNumber;
                    }
                }
                else
                {
                    oddSum += curentNumber;

                    if (curentNumber > oddMax)
                    {
                        oddMax = curentNumber;
                    }

                    if (curentNumber < oddMin)
                    {
                        oddMin = curentNumber;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");

            if (oddMin != double.MaxValue)
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
            }
            else
            {
                Console.WriteLine("OddMin=No,");
            }

            if (oddMax != double.MinValue)
            {
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            else
            {
                Console.WriteLine("OddMax=No,");
            }

            Console.WriteLine($"EvenSum={evenSum:f2},");

            if (evenMin != double.MaxValue)
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
            }

            if (evenMax != double.MinValue)
            {
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
            else
            {
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
