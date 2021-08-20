using System;

namespace Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfThePlunder = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            int expectedPlunder = int.Parse(Console.ReadLine());

            double sumPlunder = 0;

            for (int i = 1; i <= daysOfThePlunder; i++)
            {
                sumPlunder += dailyPlunder;

                if (i % 3 == 0)
                {
                    sumPlunder += dailyPlunder * 0.50;
                }
                if (i % 5 == 0)
                {
                    sumPlunder = sumPlunder * 0.70;
                }

               
            }

            if (sumPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {sumPlunder:f2} plunder gained.");
            }
            else
            {
                double percentage = sumPlunder * 100 / expectedPlunder;

                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}
