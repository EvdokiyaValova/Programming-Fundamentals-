using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int countRows = int.Parse(Console.ReadLine());
            int countColl = int.Parse(Console.ReadLine());

            int totalCount = countRows * countColl;

            double income = 0;

            switch (projectionType)
            {
                case "Premiere":
                    income = totalCount * 12.00;
                    break;
                case "Normal":
                    income = totalCount * 7.50;
                    break;
                case "Discount":
                    income = totalCount * 5.00;
                    break;
            }

            Console.WriteLine("{0:f2} leva", income);
        }
    }
}
