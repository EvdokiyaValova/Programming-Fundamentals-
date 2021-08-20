using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());

            switch (comand)
            {
                case "add":
                    Add(firstDigit, secondDigit);
                    break;

                case "subtract":
                    Subtract(firstDigit, secondDigit);
                    break;

                case "multiply":
                    Multiply(firstDigit, secondDigit);
                    break;

                case "divide":
                    Divide(firstDigit, secondDigit);
                    break;
            }



        }

        private static void Divide(int firstDigit, int secondDigit)
        {
            Console.WriteLine(firstDigit / secondDigit);
        }

        private static void Multiply(int firstDigit, int secondDigit)
        {
            Console.WriteLine(firstDigit * secondDigit);
        }

        private static void Subtract(int firstDigit, int secondDigit)
        {
            Console.WriteLine(firstDigit - secondDigit);
        }

        private static void Add(int firstDigit, int secondDigit)
        {
            Console.WriteLine(firstDigit + secondDigit);
        }

    }
}
