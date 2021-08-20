using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDay = int.Parse(Console.ReadLine());
            int placedFoodsKg = int.Parse(Console.ReadLine());
            double dogFoodsPerDayKg = double.Parse(Console.ReadLine());
            double catFoodsPerDayKg = double.Parse(Console.ReadLine());
            double turtleFoodsPerDayGrams = double.Parse(Console.ReadLine());

            double requiredQuantityDog = countDay * dogFoodsPerDayKg;
            double requiredQuantityCat = countDay * catFoodsPerDayKg;
            double requiredQuantityTurtle = countDay * turtleFoodsPerDayGrams / 1000;

            double requiredQuantityPets = requiredQuantityDog + requiredQuantityCat + requiredQuantityTurtle;

            double differenceFood = Math.Abs(placedFoodsKg - requiredQuantityPets);

            if (placedFoodsKg >= requiredQuantityPets)
            {
                Console.WriteLine($"{Math.Floor(differenceFood):f0} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(differenceFood):f0} more kilos of food are needed.");
            }

        }
    }
}
