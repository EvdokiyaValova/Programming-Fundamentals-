using System;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            int result = MathOperation(firstNumber, operation, secondNumber);

            Console.WriteLine(result);
        }

        private static int MathOperation(int firstNumber, string operation, int secondNumber)
        {
            int result = 0;

            switch (operation)
            {
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
            }

            return result;
        }
    }
}
