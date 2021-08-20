using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int sumQuantities = 0;

            for (int i = 0; i < n; i++)
            {
                int quantities = int.Parse(Console.ReadLine());

                if (capacity >= quantities)
                {
                    capacity -= quantities;
                    sumQuantities += quantities;
                }
                else if (capacity < quantities)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(sumQuantities);
        }
    }
}
