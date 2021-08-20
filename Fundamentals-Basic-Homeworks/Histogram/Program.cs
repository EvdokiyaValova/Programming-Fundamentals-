using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;
            int countP4 = 0;
            int countP5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int curentNumber = int.Parse(Console.ReadLine());

                if (curentNumber < 200)
                {
                    countP1 ++;
                }
                else if (curentNumber < 400)
                {
                    countP2 ++;
                }
                else if (curentNumber < 600)
                {
                    countP3 ++;
                }
                else if (curentNumber < 800)
                {
                    countP4 ++;
                }
                else
                {
                    countP5 ++;
                }
            }

            double p1 = countP1 * 1.0 / n * 100;
            double p2 = countP2 * 1.0 / n * 100;
            double p3 = countP3 * 1.0 / n * 100;
            double p4 = countP4 * 1.0 / n * 100;
            double p5 = countP5 * 1.0 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
