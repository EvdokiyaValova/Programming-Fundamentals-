using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hour = double.Parse(Console.ReadLine());

            double filledP1 = p1 * hour;
            double filledP2 = p2 * hour;
            double totalFilled = filledP1 + filledP2;

            double percentP1 = filledP1 * 100 / totalFilled;
            double percentP2 = filledP2 * 100 / totalFilled;
            double percentFilled = totalFilled  * 100 / volume;

            if (volume >= totalFilled)
            {
                Console.WriteLine($"The pool is {percentFilled:f2} % full.Pipe 1: {percentP1:f2}%." +
                    $"Pipe 2: {percentP2:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {hour} hours the pool overflows with {totalFilled - volume} liters.");
            }
        }
    }
}
