using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlowers = Console.ReadLine();
            int countFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceFlowers = 0;

            switch (typeFlowers)
            {
                case "Roses":
                    priceFlowers = countFlowers * 5.00;
                    if (countFlowers > 80)
                    {
                        priceFlowers = priceFlowers * 0.90;
                    }
                    break;
                case "Dahlias":
                    priceFlowers = countFlowers * 3.80;
                    if (countFlowers > 90)
                    {
                        priceFlowers = priceFlowers * 0.85;
                    }
                    break;
                case "Tulips":
                    priceFlowers = countFlowers * 2.80;
                    if (countFlowers > 80)
                    {
                        priceFlowers = priceFlowers * 0.85;
                    }
                    break;
                case "Narcissus":
                    priceFlowers = countFlowers * 3.00;
                    if (countFlowers < 120)
                    {
                        priceFlowers = priceFlowers * 1.15;
                    }
                    break;
                case "Gladiolus":
                    priceFlowers = countFlowers * 2.50;
                    if (countFlowers < 80)
                    {
                        priceFlowers = priceFlowers * 1.20;
                    }
                    break;
            }

            double restAmount = Math.Abs(budget - priceFlowers);

            if (budget >= priceFlowers)
            {
                Console.WriteLine($"Hey, you have a great garden with {countFlowers} {typeFlowers} and {restAmount:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {restAmount:f2} leva more.");
            }
        }
    }
}
