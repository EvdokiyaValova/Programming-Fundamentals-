using System;

namespace _03Exam_Excursion_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double priceForTrip = 0;

            if (season == "spring")
            {
                if (numberPeople <= 5)
                {
                    priceForTrip = numberPeople * 50.00;
                }
                else if (numberPeople > 5)
                {
                    priceForTrip = numberPeople * 48.00;
                }
            }
            else if (season == "summer")
            {
                if (numberPeople <= 5)
                {
                    priceForTrip = numberPeople * 48.50 * 0.85;
                }
                else if (numberPeople > 5)
                {
                    priceForTrip = numberPeople * 45.00 * 0.85;
                }
            }
            else if (season == "autumn")
            {
                if (numberPeople <= 5)
                {
                    priceForTrip = numberPeople * 60.00;
                }
                else if (numberPeople > 5)
                {
                    priceForTrip = numberPeople * 49.50;
                }
            }
            else if (season == "winter")
            {
                if (numberPeople <= 5)
                {
                    priceForTrip = numberPeople * 86.00 * 1.08;
                }
                else if (numberPeople > 5)
                {
                    priceForTrip = numberPeople * 85.00 * 1.08;
                }
            }

            Console.WriteLine($"{priceForTrip:f2} leva.");
        }
    }
}
