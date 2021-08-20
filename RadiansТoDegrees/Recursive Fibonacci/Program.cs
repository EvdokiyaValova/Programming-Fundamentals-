using System;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFibonacci = int.Parse(Console.ReadLine());

            int[] arrFibonacci = new int[numberFibonacci];

            for (int i = 0; i < arrFibonacci.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    arrFibonacci[i] = 1;
                }
                else if (i > 1 && i < arrFibonacci.Length)
                {
                    arrFibonacci[i] = arrFibonacci[i - 1] + arrFibonacci[i - 2];
                }
            }

            Console.WriteLine(arrFibonacci[arrFibonacci.Length - 1]);
        }
    }
}
