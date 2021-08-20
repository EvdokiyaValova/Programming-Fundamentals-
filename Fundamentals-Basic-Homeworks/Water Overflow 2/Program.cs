using System;

namespace Water_Overflow_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int capacity = 255;
            int quantities = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                int litres = int.Parse(Console.ReadLine());

                if (litres <= capacity)
                {
                    capacity -= litres;
                    quantities += litres;
                }
                else if (litres > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
            }

            Console.WriteLine(quantities);
        }
    }
}
