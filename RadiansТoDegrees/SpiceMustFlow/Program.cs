using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int dayWork = 0;
            int totalYield = 0;

            while (startingYield >= 100)
            {
                dayWork++;
                totalYield += startingYield;
                totalYield -= 26;
                startingYield -= 10;

            }
            if (totalYield >=26)
            {
                totalYield -= 26;
            }
            

            Console.WriteLine(dayWork);
            Console.WriteLine(totalYield);
        }
    }
}
