using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productsPrice = new Dictionary<string, decimal>();
            Dictionary<string, int> productsQuantity = new Dictionary<string, int>();

            while (true)
            {
                string[] currentProduct = Console.ReadLine().Split();                

                if (currentProduct[0] == "buy")
                {
                    break;
                }

                string product = currentProduct[0];
                decimal price = decimal.Parse(currentProduct[1]);
                int quantity = int.Parse(currentProduct[2]);

                if (productsPrice.ContainsKey(product) == false)
                {
                    productsPrice.Add(product, price);
                    productsQuantity.Add(product, quantity);
                }
                else
                {
                    productsQuantity[product] += quantity;
                    productsPrice[product] = price;
                }
            }

            foreach (var kvp in productsPrice)
            {
                string produkt = kvp.Key;
                decimal price = kvp.Value;
                int quantity = productsQuantity[produkt];

                decimal totalPrice = price * quantity;

                Console.WriteLine($"{kvp.Key} -> {totalPrice:f2}");
            }
            
        }
    }
}
