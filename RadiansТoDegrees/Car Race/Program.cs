using System;
using System.Collections.Generic;
using System.Linq;

namespace Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> time = Console.ReadLine().Split().Select(int.Parse).ToList();

            double leftCar = 0;

            for (int i = 0; i < time.Count / 2; i++)
            {
                leftCar += time[i];
                if (time[i] == 0)
                {
                    leftCar = leftCar * 0.8;
                }
            }

            double rightCar = 0;

            for (int i = time.Count - 1; i > time.Count / 2; i--)
            {
                rightCar += time[i];
                if (time[i] == 0)
                {
                    rightCar = rightCar * 0.8;
                }
            }

            if (leftCar > rightCar)
            {
                Console.WriteLine($"The winner is right with total time: {rightCar}");
            }
            else
            {
                Console.WriteLine($"The winner is left with total time: {leftCar}");
            }
        }
    }
}
