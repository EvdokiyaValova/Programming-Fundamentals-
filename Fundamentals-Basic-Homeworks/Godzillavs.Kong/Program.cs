using System;

namespace Godzillavs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetMovie = double.Parse(Console.ReadLine());
            int countExtras = int.Parse(Console.ReadLine());
            double priceOneCloting = double.Parse(Console.ReadLine());

            double decor = budgetMovie * 0.10;
            double priceCloting = countExtras * priceOneCloting;

            if (countExtras >= 150)
            {
                priceCloting = priceCloting * 0.90;
            }

            double expense = decor + priceCloting;

            if (expense > budgetMovie)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(expense - budgetMovie):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budgetMovie - expense):f2} leva left.");
            }
        }
    }
}
