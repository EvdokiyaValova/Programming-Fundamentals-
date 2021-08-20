using System;

namespace Convert_Meters_to_Kilometers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int distansMeters = int.Parse(Console.ReadLine());

            decimal distansKilometers = distansMeters / 1000.0M;

            Console.WriteLine($"{distansKilometers:f2}");
        }
    }
}
