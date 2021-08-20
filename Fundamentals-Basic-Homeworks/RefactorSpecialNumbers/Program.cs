using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumDigit = 0;
            //int takova  = 0;
            bool flag = false;
            for (int i = 1; i <= n; i++)
            {
                int digit = i;
                while (i > 0)
                {
                    sumDigit += i % 10;
                    i = i / 10;
                }
                flag = (sumDigit == 5) || (sumDigit == 7) || (sumDigit == 11);
                Console.WriteLine("{0} -> {1}", digit, flag);
                sumDigit = 0;
                i = digit;
            }

        }
    }
}
