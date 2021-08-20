using System;
using System.Linq;

namespace _01_Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] timeSinoLeaves = Console.ReadLine()
                                          .Split(":")
                                          .Select(int.Parse)
                                          .ToArray();
            int numerSteps = int.Parse(Console.ReadLine());
            int timeSecondsForEachStep = int.Parse(Console.ReadLine());

            int timeWalking = numerSteps * timeSecondsForEachStep;

            int timaLeavingSeconds = timeSinoLeaves[0] * 3600 
                                   + timeSinoLeaves[1] * 60
                                   + timeSinoLeaves[2];
            int timeAriveInSeconds = timaLeavingSeconds + timeWalking;            

            int timeAriveHour = timeAriveInSeconds / 3600;
            int timeAriveMinutes = (timeAriveInSeconds % 3600) / 60;
            int timeAriveSeconds = timeAriveInSeconds - (timeAriveHour * 3600) - (timeAriveMinutes * 60);
            
            if (timeAriveHour > 23)
            {
                timeAriveHour = timeAriveHour - 24;
            }

            Console.WriteLine($"Time Arrival: {timeAriveHour:d02}:{timeAriveMinutes:d02}:{timeAriveSeconds:d02}");
        }
    }
}
