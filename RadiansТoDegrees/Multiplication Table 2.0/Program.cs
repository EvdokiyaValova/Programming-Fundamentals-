using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerNumber = int.Parse(Console.ReadLine());
            int givenMultiplier = int.Parse(Console.ReadLine());

            
            do
            {
                int product = integerNumber * givenMultiplier;
                Console.WriteLine($"{integerNumber} X {givenMultiplier} = {product}");
                givenMultiplier++;
            } while (givenMultiplier <= 10);
        }
    }
}
