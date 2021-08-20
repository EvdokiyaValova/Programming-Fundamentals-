using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;

            while (input != "NoMoreMoney")
            {
                double increase = double.Parse(input);

                if (increase < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {increase:f2}");
                sum += increase;

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
