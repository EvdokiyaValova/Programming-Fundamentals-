using System;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currentNumber = 1;

            while (currentNumber <= n)
            {
                Console.WriteLine(currentNumber);

                currentNumber = currentNumber * 2 + 1;
            }
        }
    }
}
