using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysForStay = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string grade = Console.ReadLine();

            int night = daysForStay - 1;
            double priceNights = 0;

            switch (typeOfRoom)
            {
                case "room for one person":
                    priceNights = night * 18.00;
                    break;
                case "apartment":
                    priceNights = night * 25.00;
                    break;
                case "president apartment":
                    priceNights = night * 35.00;
                    break;               
            }
            if (daysForStay < 10)
            {
                switch (typeOfRoom)
                {
                    case "apartment":
                        priceNights = priceNights * 0.70;
                        break;
                    case "president apartment":
                        priceNights = priceNights * 0.90;
                        break;
                }
            }
            else if (daysForStay <= 15)
            {
                switch (typeOfRoom)
                {
                    case "apartment":
                        priceNights = priceNights * 0.65;
                        break;
                    case "president apartment":
                        priceNights = priceNights * 0.85;
                        break;
                }
            }
            else if (daysForStay > 15)
            {
                switch (typeOfRoom)
                {
                    case "apartment":
                        priceNights = priceNights * 0.50;
                        break;
                    case "president apartment":
                        priceNights = priceNights * 0.80;
                        break;
                }
            }

            switch (grade)
            {
                case "positive":
                    priceNights = priceNights * 1.25;
                    break;
                case "negative":
                    priceNights = priceNights * 0.90;
                    break;
            }

            Console.WriteLine("{0:f2}", priceNights);
        }
    }
}
