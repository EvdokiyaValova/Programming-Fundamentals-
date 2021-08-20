using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSimbol = int.Parse(Console.ReadLine());
            int lastSimbol = int.Parse(Console.ReadLine());

            for (int i = firstSimbol; i <= lastSimbol; i++)
            {
                char currentSimbol = (char)i;
                Console.Write($"{currentSimbol} ");
            }

            
        }
    }
}
