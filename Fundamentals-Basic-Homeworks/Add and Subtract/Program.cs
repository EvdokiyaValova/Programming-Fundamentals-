using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = SumFirstTwoNumbers(firstNumber, secondNumber);
            int subtract = Subtract(sum, thirdNumber);

            Console.WriteLine(subtract);
        }

        private static int Subtract(int sum, int thirdNumber)
        {
            int subtract = sum - thirdNumber;
            return subtract;
        }

        static int SumFirstTwoNumbers(int firstNumber, int secondNumber)
        {
            int sumFirstTwoNumber = firstNumber + secondNumber;
            return sumFirstTwoNumber;
        }
    }
}
