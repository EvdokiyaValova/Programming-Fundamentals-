using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());


            int areaRectangle = CalculationAreaRectangle(sideA, sideB);
        }

        private static int CalculationAreaRectangle(int sideA, int sideB)
        {
            int areaRectangle = sideA * sideB;
            Console.WriteLine(areaRectangle);
            
            return areaRectangle;
        }
    }
}
