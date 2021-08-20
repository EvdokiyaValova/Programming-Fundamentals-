using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string typeSeason = Console.ReadLine();

            string typeOfVacation = "";
            string destination = "";
            double amountSpent = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (typeSeason)
                {
                    case "summer":
                        typeOfVacation = "Camp";
                        amountSpent = budget * 0.30;
                        break;
                    case "winter":
                        typeOfVacation = "Hotel";
                        amountSpent = budget * 0.70;
                        break;
                }

            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                switch (typeSeason)
                {
                    case "summer":
                        typeOfVacation = "Camp";
                        amountSpent = budget * 0.40;
                        break;
                    case "winter":
                        typeOfVacation = "Hotel";
                        amountSpent = budget * 0.80;
                        break;
                }

            }

            else if (budget > 1000)
            {
                destination = "Europe";
                typeOfVacation = "Hotel";
                amountSpent = budget * 0.90;

            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfVacation} - {amountSpent:f2}");
        }
    }
}
