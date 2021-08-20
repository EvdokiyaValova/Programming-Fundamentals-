using System;

namespace Spice_Must_Flow_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int quantityYield = 0;
            int woringsDays = 0;

            while (startingYield >= 100)
            {
                quantityYield += startingYield;
                woringsDays++;
                if (quantityYield >= 26)
                {
                    quantityYield -= 26;
                }
                startingYield -= 10;
            }

            if (quantityYield >= 26)
            {
                quantityYield -= 26;
            }

            Console.WriteLine(woringsDays);
            Console.WriteLine(quantityYield);
        }
    }
}
