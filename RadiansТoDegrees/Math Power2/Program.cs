﻿using System;

namespace Math_Power2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = RaiseToPower(number, power);

            Console.WriteLine(result);
        }

        private static double RaiseToPower(double number, int power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}
