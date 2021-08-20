using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int digit = number;

            int sumDigit = 0;

            while (digit > 0)
            {
                sumDigit += digit % 10;
                digit = digit / 10;
            }

            Console.WriteLine(sumDigit);
        }
    }
}
