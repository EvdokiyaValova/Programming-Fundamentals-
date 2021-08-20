using System;

namespace Pounds_to_Dollars_2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal inputPounds = decimal.Parse(Console.ReadLine());

            decimal outputDollars = inputPounds * 1.31M;

            Console.WriteLine($"{outputDollars:f3}");
        }
    }
}
