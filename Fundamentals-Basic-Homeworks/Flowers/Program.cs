using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countChrysanthemums = int.Parse(Console.ReadLine());
            int countRoses = int.Parse(Console.ReadLine());
            int countTulips  = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string typeDay = Console.ReadLine();

            double priceChrysanthemums = 0;
            double priceRoses = 0;
            double priceTulips  = 0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    priceChrysanthemums = countChrysanthemums * 2.00;
                    priceRoses = countRoses * 4.10;
                    priceTulips = countTulips * 2.50;
                    break;

                case "Autumn":
                case "Winter":
                    priceChrysanthemums = countChrysanthemums * 3.75;
                    priceRoses = countRoses * 4.50;
                    priceTulips = countTulips * 4.15;
                    break;
            }

            int countFlowers = countChrysanthemums + countRoses + countTulips;
            double priceFlowers = priceChrysanthemums + priceRoses + priceTulips;

            switch (typeDay)
            {
                case "Y":
                priceFlowers = priceFlowers * 1.15;
                    break;
            }

            if (countTulips > 7 && season == "Spring")
            {
                priceFlowers = priceFlowers * 0.95;
            }

            if (countRoses >= 10 && season == "Winter")
            {
                priceFlowers = priceFlowers * 0.90;
            }

            if (countFlowers > 20)
            {
                priceFlowers = priceFlowers * 0.80;
            }

            double bouquetPrice = priceFlowers + 2;

            Console.WriteLine($"{bouquetPrice:f2}");
        }
    }
}
