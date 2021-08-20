using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int areaVineyard = int.Parse(Console.ReadLine());
            double grapesOneMeters = double.Parse(Console.ReadLine());
            int neededLitersWine = int.Parse(Console.ReadLine());
            int countWorkers = int.Parse(Console.ReadLine());

            double totalGrapes = areaVineyard * grapesOneMeters * 0.4;
            double producedWine = totalGrapes / 2.5;
            
            if (producedWine < neededLitersWine)
            {
                double notEnoughWine = neededLitersWine - producedWine;

                Console.WriteLine($"It will be a tough winter! More {Math.Floor(notEnoughWine):f0} liters wine needed.");
            }
            else
            {
                double enoughWine = producedWine - neededLitersWine;
                double wineForOne = enoughWine / countWorkers;

                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(producedWine):f0} liters.");
                Console.WriteLine($"{Math.Ceiling(enoughWine):f0} liters left -> {Math.Ceiling(wineForOne):f0} liters per person.");
            }
        }
    }
}
