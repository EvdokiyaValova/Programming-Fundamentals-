using System;

namespace Factorial_Division2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            long factorialFirstNumber = FactorialIsNumber(firstNumber);
  //          Console.WriteLine(factorialFirstNumber);
            long factorialSecondNumber = FactorialIsNumber(secondNumber);
 //           Console.WriteLine(factorialSecondNumber);

            double result = DivisionFactorials(factorialFirstNumber, factorialSecondNumber);
            Console.WriteLine($"{result:f2}");
        }

        private static double DivisionFactorials(double factorialFirstNumber, double factorialSecondNumber)
        {
            double divisionFactorials = factorialFirstNumber * 1.0 / factorialSecondNumber;
            return divisionFactorials;
        }

        private static long FactorialIsNumber(int number)
        {
            long factorialIsNumber = 1;
            for (int i = 1; i <= number; i++)
            {
                factorialIsNumber *= i;
            }

            return factorialIsNumber;
        }
    }
}
