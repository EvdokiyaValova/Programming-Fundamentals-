using System;

namespace Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double sumElements = 0;
            string comand = "";

            while (input != "special" || input != "special")
            {
                if (input == "special")
                {
                    comand = "special";
                    break;
                }
                else if (input == "regular")
                {
                    comand = "regular";
                    break;
                }
                else
                {
                    double priceElement = double.Parse(input);

                    if (priceElement < 0)
                    {
                        Console.WriteLine("Invalid price!");
                    }
                    else
                    {
                        sumElements += priceElement;
                    }
                }

                input = Console.ReadLine();
            }

            if (sumElements == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            else
            {
                double taxes = sumElements * 0.20;
                double totalPrice = sumElements + taxes;

                if (input == "special")
                {
                    totalPrice = totalPrice * 0.90;
                }

                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sumElements:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }            
        }
    }
}
