using System;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            int workinkDays = 365 - holidays;
            int gameWorkingDays = workinkDays * 63;
            int gameHolidays = holidays * 127;

            int totalTimeGame = gameWorkingDays + gameHolidays;

            if (totalTimeGame > 30000)
            {
                int more = totalTimeGame - 30000;
                int hourGame = more / 60;
                int minutes = more % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hourGame} hours and {minutes} minutes more for play");
            }
            else
            {
                int more = 30000 - totalTimeGame;
                int hourGame = more / 60;
                int minutes = more % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hourGame} hours and {minutes} minutes less for play");
            }
        }
    }
}
