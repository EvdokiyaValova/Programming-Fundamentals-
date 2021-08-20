using System;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string categoryTicket = Console.ReadLine();
            int countPeopleGroup = int.Parse(Console.ReadLine());

            double moneyForTicket = 0;

            if (countPeopleGroup >= 50)
            {
                moneyForTicket = budget * 0.75;
            }
            else if (countPeopleGroup >= 25)
            {
                moneyForTicket = budget * 0.60;
            }
            else if (countPeopleGroup >= 10)
            {
                moneyForTicket = budget * 0.50;
            }
            else if (countPeopleGroup >= 5)
            {
                moneyForTicket = budget * 0.40;
            }
            else if (countPeopleGroup >= 1)
            {
                moneyForTicket = budget * 0.25;
            }

            double priceTicket = 0;

            switch (categoryTicket)
            {
                case "VIP":
                    priceTicket = countPeopleGroup * 499.99;
                    break;
                case "Normal":
                    priceTicket = countPeopleGroup * 249.99;
                    break;
            }

            double rest = moneyForTicket - priceTicket;

            if (rest >= 0)
            {
                Console.WriteLine($"Yes! You have {rest:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(rest):f2} leva.");
            }
        }
    }
}
