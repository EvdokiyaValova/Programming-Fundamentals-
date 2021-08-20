using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputNumber = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            double unit;
            if (inputUnit == "mm")
            {
                unit = inputNumber / 1000;
            }
            else if (inputUnit == "cm")
            {
                unit = inputNumber / 100;
            }
            else
            {
                unit = inputNumber;
            }

            if (outputUnit == "mm")
            {
                unit = unit * 1000;
            }
            else if (outputUnit == "cm")
            {
                unit = unit * 100;
            }
            else
            {
                unit = unit * 1;
            }

            Console.WriteLine($"{unit:f3}");
        }
    }
}
