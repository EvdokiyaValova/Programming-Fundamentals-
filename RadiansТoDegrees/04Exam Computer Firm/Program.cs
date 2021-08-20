using System;

namespace _04Exam_Computer_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double totalSales = 0;
            double sumRating = 0;

            for (int i = 1; i <= n; i++)
            {
                int numberComputer = int.Parse(Console.ReadLine());

                int rating = 0;

                if (numberComputer % 10 == 2)
                {
                    rating += 2;
                }
                else if (numberComputer % 10 == 3)
                {
                    rating += 3;
                }
                else if (numberComputer % 10 == 4)
                {
                    rating += 4;
                }
                else if (numberComputer % 10 == 5)
                {
                    rating += 5;
                }
                else if (numberComputer % 10 == 6)
                {
                    rating += 6 ;
                }

                sumRating += rating;

                int possibleSales = numberComputer / 10;
                double salesMade = 0;

                if (rating == 2)
                {
                    salesMade = possibleSales * 0;
                }
                else if (rating == 3)
                {
                    salesMade = possibleSales * 0.50;
                }
                else if (rating == 4)
                {
                    salesMade = possibleSales * 0.70;
                }
                else if (rating == 5)
                {
                    salesMade = possibleSales * 0.85;
                }
                else if (rating == 6)
                {
                    salesMade = possibleSales * 1.00;
                }

                totalSales += salesMade;                
            }

            double averageRating = sumRating * 1.0 / n;

            Console.WriteLine($"{totalSales:f2}");
            Console.WriteLine($"{averageRating:f2}");
        }
    }
}
