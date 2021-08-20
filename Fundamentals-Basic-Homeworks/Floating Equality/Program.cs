using System;
using System.Linq;

namespace Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputArr = new double[2];
            for (int i = 0; i < inputArr.Length; i++)
            {
                inputArr[i] = double.Parse(Console.ReadLine());
            }

            double firstNumber = inputArr[0];
            double secondNumber = inputArr[1];
            double eps = 0.000001;

            bool isEqual = Math.Abs(firstNumber - secondNumber) < eps;

            if (isEqual)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }   

    }
}
