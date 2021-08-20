using System;

namespace ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanseMeters = int.Parse(Console.ReadLine());

            decimal distanceKilometer = distanseMeters / 1000M;

            Console.WriteLine($"{distanceKilometer:f2}");
        }
    }
}
