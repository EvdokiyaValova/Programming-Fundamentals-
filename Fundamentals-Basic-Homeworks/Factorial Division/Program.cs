using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firsNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int firstFactorial = NumberFactorial(firsNumber);
            int secondFactorial = NumberFactorial(secondNumber);            

            double divideFacrorial = DivideFactoriel(firstFactorial, secondFactorial);

            Console.WriteLine($"{divideFacrorial:f2}");
        }

         static double DivideFactoriel(double firstFactorial, int secondFactorial)
        {
            double divideNumbers = firstFactorial / secondFactorial;
            return divideNumbers;
        }

        static int NumberFactorial(int number)
        {

            int numberFactorial = 1;
            for (int i = 1; i <= number; i++)
            {
                numberFactorial *= i;
            }

            return numberFactorial;
        }
    }
}
