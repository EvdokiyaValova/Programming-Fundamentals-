using System;

namespace Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFuel = Console.ReadLine();
            double quantityFuel = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double priceFuelLiter = 0;

            if (clubCard =="Yes")
            {               

                if (typeFuel == "Gasoline")
                {
                    priceFuelLiter = 2.22 - 0.18;
                }
                else if (typeFuel == "Diesel")
                {
                    priceFuelLiter = 2.33 - 0.12;
                }
                else if (typeFuel == "Gas")
                {
                    priceFuelLiter = 0.93 - 0.08;
                }

            }
            else
            {
                if (typeFuel == "Gasoline")
                {
                    priceFuelLiter = 2.22;
                }
                else if (typeFuel == "Diesel")
                {
                    priceFuelLiter = 2.33;
                }
                else if (typeFuel == "Gas")
                {
                    priceFuelLiter = 0.93;
                }

            }

            double sumFuel = quantityFuel * priceFuelLiter;

            double discountQuantity = 0;

            if (quantityFuel > 25)
            {
                discountQuantity = sumFuel * 0.10;
            }
            else if (quantityFuel > 20)
            {
                discountQuantity = sumFuel * 0.08;
            }

            double totalSum = sumFuel - discountQuantity;

            Console.WriteLine($"{totalSum:f2} lv.");
        }
    }
}
