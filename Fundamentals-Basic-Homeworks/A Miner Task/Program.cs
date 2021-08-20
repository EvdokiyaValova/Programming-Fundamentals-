using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> quantityByElements = new Dictionary<string, int>();
                        
            while (true)
            {
                string currentElement = Console.ReadLine();

                if (currentElement == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (quantityByElements.ContainsKey(currentElement))
                {
                    quantityByElements[currentElement] += quantity;
                }
                else
                {
                    quantityByElements.Add(currentElement, quantity);
                }
            }

            foreach (var kvp in quantityByElements)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
