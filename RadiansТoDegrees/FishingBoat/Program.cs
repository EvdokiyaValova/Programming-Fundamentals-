using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budgetGroup = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countFisherman = int.Parse(Console.ReadLine());

            double priceBoat = 0;

            switch (season)
            {
                case "Spring":
                    priceBoat = 3000;
                    break;
                case "Summer":
                    priceBoat = 4200;
                    break;
                case "Autumn":
                    priceBoat = 4200;
                    break;
                case "Winter":
                    priceBoat = 2600;
                    break;
            }

            if (countFisherman <= 6 )
            {
                priceBoat = priceBoat * 0.90;
            }
            else if (countFisherman <= 11)
            {
                priceBoat = priceBoat * 0.85;
            }
            else if (countFisherman > 12)
            {
                priceBoat = priceBoat * 0.75;
            }

            if (countFisherman % 2 == 0 && season != "Autumn")
            {
                priceBoat = priceBoat * 0.95;
            }

            double restAmount = Math.Abs(budgetGroup - priceBoat);

            if (budgetGroup >= priceBoat)
            {
                Console.WriteLine($"Yes! You have {restAmount:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {restAmount:f2} leva.");
            }
        }
    }
}
