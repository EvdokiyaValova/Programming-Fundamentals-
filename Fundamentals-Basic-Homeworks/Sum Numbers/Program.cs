using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;

            while (sum < number)
            {
                int currentNumber = int.Parse(input);

                sum += currentNumber;

                input = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }
    }
}
