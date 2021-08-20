using System;

namespace Refactor_Volume_of_Pyramid_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // double dul, sh, V = 0;
            
            double length = double.Parse(Console.ReadLine());            
            double width = double.Parse(Console.ReadLine());            
            double height = double.Parse(Console.ReadLine());

            //V = (dul + sh + V) / 3;
            double volume = (length * width * height) / 3;

            Console.Write($"Length: ");
            Console.Write("Width: ");
            Console.Write("Height: ");
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }

    }
}
