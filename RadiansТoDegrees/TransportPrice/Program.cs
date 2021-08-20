using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int countKm = int.Parse(Console.ReadLine());
            string periodOfDay = Console.ReadLine();

            double transportPrice;
            if (countKm >= 100)
            {
                 transportPrice = countKm * 0.06;
            }
            else if (countKm >= 20)
            {
                transportPrice = countKm * 0.09;
            }
            else
            {
                if (periodOfDay == "day")
                {
                    transportPrice = countKm * 0.79 + 0.70;
                }
                else
                {
                    transportPrice = countKm * 0.90 + 0.70;
                }
            }

            Console.WriteLine($"{transportPrice:f2}");
        }
    }
}
