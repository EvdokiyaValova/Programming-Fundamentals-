using System;

namespace FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFuel = Console.ReadLine();
            double litresFuel = double.Parse(Console.ReadLine());

            if (typeFuel == "Diesel")
            {
                if (litresFuel >= 25)
                {
                    Console.WriteLine($"You have enough {typeFuel.ToLower()}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {typeFuel.ToLower()}!");
                }
            }
            else if (typeFuel == "Gasoline")
            {
                if (litresFuel >= 25)
                {
                    Console.WriteLine($"You have enough {typeFuel.ToLower()}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {typeFuel.ToLower()}!");
                }
            }
            else if (typeFuel == "Gas")
            {
                if (litresFuel >= 25)
                {
                    Console.WriteLine($"You have enough {typeFuel.ToLower()}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {typeFuel.ToLower()}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
