using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberKeg = int.Parse(Console.ReadLine());

            double maxVolume = 0;
            string biggeestKeg = "";

            for (int i = 0; i < numberKeg; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume= Math.PI * radius * radius * height;

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    biggeestKeg = model;
                }
            }

            Console.WriteLine(biggeestKeg);
        }
    }
}
