using System;

namespace NumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < -100)
            {
                Console.WriteLine("No");
            }
            else if (number < 0)
            {
                Console.WriteLine("Yes");
            }
            else if (number == 0)
            {
                Console.WriteLine("No");
            }
            else if (number <= 100)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
