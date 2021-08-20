using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int product = integerNumber * i;

                Console.WriteLine($"{integerNumber} X {i} = {product}");
            }
        }
    }
}
