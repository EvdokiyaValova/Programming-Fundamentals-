using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double gameSf = (48 - h)* 1.0 * 3 / 4;
            double gameHolidays = p * 1.0 * 2 / 3;

            double totalGame = gameSf + h + gameHolidays;

            if (typeYear == "leap")
            {
                totalGame = totalGame * 1.15;
            }

            Console.WriteLine($"{Math.Floor(totalGame):f0}");
        }
    }
}
