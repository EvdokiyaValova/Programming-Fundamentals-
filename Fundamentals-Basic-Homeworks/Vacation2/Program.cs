using System;

namespace Vacation2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            double priceForOne = 0;

            if (dayOfTheWeek == "Friday")
            {
                if (typeOfGroup == "Students")
                {
                    priceForOne = 8.45;
                }
                else if (typeOfGroup == "Business")
                {
                    priceForOne = 10.90;
                }
                else if (typeOfGroup == "Regular")
                {
                    priceForOne = 15;
                }
            }
            else if (dayOfTheWeek == "Saturday")
            {
                if (typeOfGroup == "Students")
                {
                    priceForOne = 9.80;
                }
                else if (typeOfGroup == "Business")
                {
                    priceForOne = 15.60;
                }
                else if (typeOfGroup == "Regular")
                {
                    priceForOne = 20;
                }
            }
            else if (dayOfTheWeek == "Sunday")
            {
                if (typeOfGroup == "Students")
                {
                    priceForOne = 10.46;
                }
                else if (typeOfGroup == "Business")
                {
                    priceForOne = 16;
                }
                else if (typeOfGroup == "Regular")
                {
                    priceForOne = 22.50;
                }
            }

            double priceForGroup = priceForOne * numberPeople;

            if (typeOfGroup == "Students" && numberPeople >= 30)
            {
                priceForGroup = priceForGroup * 0.85;
            }
            else if (typeOfGroup == "Business" && numberPeople >= 100)
            {
                priceForGroup = priceForOne * (numberPeople - 10);
            }
            else if (typeOfGroup == "Regular" && numberPeople >= 10 && numberPeople <= 20)
            {
                priceForGroup = priceForGroup * 0.95;
            }

            Console.WriteLine($"Total price: {priceForGroup:f2}");
        }
    }
}
