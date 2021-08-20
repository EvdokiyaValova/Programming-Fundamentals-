using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double emolument = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimumWage = double.Parse(Console.ReadLine());

            double excellentScholarship = averageSuccess * 25;
            double socialScholarship = minimumWage * 0.35;

            if (averageSuccess >= 5.5 && emolument <= minimumWage)
            {
                if (excellentScholarship >= socialScholarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                }
            }
            else if (averageSuccess >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
            }
            else if (averageSuccess >= 4.5 && emolument <= minimumWage)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
