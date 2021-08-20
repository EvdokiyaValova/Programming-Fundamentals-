using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCoins = Console.ReadLine();
            double amountCoins = 0;

            while (inputCoins != "Start")
            {
                double coins = double.Parse(inputCoins);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    amountCoins += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                inputCoins = Console.ReadLine();
            }

            string inputProduct = Console.ReadLine();

            while (inputProduct != "End")
            {
                string currentProduct = inputProduct;

                if (currentProduct == "Nuts")
                {
                    if (amountCoins >= 2.0)
                    {
                        amountCoins -= 2.0;
                        Console.WriteLine($"Purchased {currentProduct.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    
                }
                else if (currentProduct == "Water")
                {
                    if (amountCoins >= 0.7)
                    {
                        amountCoins -= 0.7;
                        Console.WriteLine($"Purchased {currentProduct.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (currentProduct == "Crisps")
                {
                    if (amountCoins >= 1.5)
                    {
                        amountCoins -= 1.5;
                        Console.WriteLine($"Purchased {currentProduct.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (currentProduct == "Soda")
                {
                    if (amountCoins >= 0.8)
                    {
                        amountCoins -= 0.8;
                        Console.WriteLine($"Purchased {currentProduct.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (currentProduct == "Coke")
                {
                    if (amountCoins >= 1.0)
                    {
                        amountCoins -= 1.0;
                        Console.WriteLine($"Purchased {currentProduct.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                inputProduct = Console.ReadLine();
            }

            Console.WriteLine($"Change: {amountCoins:f2}");
        }
    }
}
