using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFigure = Console.ReadLine();

            if (typeFigure == "square")
            {
                double siteSquare = double.Parse(Console.ReadLine());

                double areaSquare = siteSquare * siteSquare;

                Console.WriteLine($"{areaSquare:F3}");
            }
            else if (typeFigure == "rectangle")
            {
                double siteRectangleA = double.Parse(Console.ReadLine());
                double siteRectangleB = double.Parse(Console.ReadLine());

                double areaRectangle = siteRectangleA * siteRectangleB;

                Console.WriteLine($"{areaRectangle:f3}");
            }
            else if (typeFigure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                
                double areaCircle = Math.PI *r*r;

                Console.WriteLine($"{areaCircle:f3}");
            }
            else if (typeFigure == "triangle")
            {
                double siteTriangleA = double.Parse(Console.ReadLine());
                double hight = double.Parse(Console.ReadLine());

                double areaTriangle = siteTriangleA * hight / 2;

                Console.WriteLine($"{areaTriangle:f3}");
            }
        }
    }
}
