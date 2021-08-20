using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());

            decimal dolar = pounds * 1.31M;

            Console.WriteLine($"{dolar:f3}");
        }
    }
}
