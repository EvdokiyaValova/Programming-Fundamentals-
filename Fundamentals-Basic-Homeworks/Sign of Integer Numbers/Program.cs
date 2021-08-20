using System;

namespace Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            NumberIsPositiveOrNegative(number);
        }

        private static void NumberIsPositiveOrNegative(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
