using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberJuniorCyclists = int.Parse(Console.ReadLine());
            int numberSeniorCyclists = int.Parse(Console.ReadLine());
            string typeRoute = Console.ReadLine();

            double feeJunior = 0;
            double feeSenior = 0;
            int allCyclists = numberJuniorCyclists + numberSeniorCyclists;

            switch (typeRoute)
            {
                case "trail":
                    feeJunior = numberJuniorCyclists * 5.50;
                    feeSenior = numberSeniorCyclists * 7.00;
                    break;

                case "cross-country":
                    feeJunior = numberJuniorCyclists * 8.00;
                    feeSenior = numberSeniorCyclists * 9.50;

                    if (allCyclists >= 50)
                    {
                        feeJunior = feeJunior * 0.75;
                        feeSenior = feeSenior * 0.75;
                    }
                    break;

                case "downhill":
                    feeJunior = numberJuniorCyclists * 12.25;
                    feeSenior = numberSeniorCyclists * 13.75;
                    break;

                case "road":
                    feeJunior = numberJuniorCyclists * 20.00;
                    feeSenior = numberSeniorCyclists * 21.50;
                    break;
            }

            double sumFee = feeJunior + feeSenior;
            double donatedAmount = sumFee * 0.95;

            Console.WriteLine($"{donatedAmount:f2}");

        }
    }
}
