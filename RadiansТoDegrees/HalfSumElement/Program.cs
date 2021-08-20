using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int curentNumber = int.Parse(Console.ReadLine());

                sum += curentNumber;
                if (curentNumber > maxNumber)
                {
                    maxNumber = curentNumber;
                }
            }

            int dif = Math.Abs(maxNumber - (sum - maxNumber));

            if (maxNumber == sum - maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {dif}");
            }
        }
    }
}
