using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSecond = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeSecondOneMeter = double.Parse(Console.ReadLine());

            double slowDown = Math.Floor(distanceMeters / 15) * 12.5;
            double timeSwiming = distanceMeters * timeSecondOneMeter + slowDown;

            if (timeSwiming < recordSecond)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {timeSwiming:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(timeSwiming - recordSecond):f2} seconds slower.");
            }
        }
    }
}
