using System;

namespace _01._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int student = int.Parse(Console.ReadLine());
            double priceFlourForPackage = double.Parse(Console.ReadLine());
            double priceSingleEgg = double.Parse(Console.ReadLine());
            double priceSingleApron = double.Parse(Console.ReadLine());

            int freeFlour = student / 5;
            double flour = (student - freeFlour) * priceFlourForPackage;
            double eggs = student * 10 * priceSingleEgg;
            double upApron = Math.Ceiling(student * 1.20);
            double aprons = upApron * priceSingleApron;

            double totalPrice = flour + eggs + aprons;

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Items purchased for {totalPrice:f2}$.");
            }
            else
            {
                double diff = totalPrice - budget;
                Console.WriteLine($"{diff:f2}$ more needed.");
            }
        }
    }
}
