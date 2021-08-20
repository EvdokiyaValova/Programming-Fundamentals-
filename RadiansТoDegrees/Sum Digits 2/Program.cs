using System;

namespace Sum_Digits_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();

            int[] arr = new int[inputNumber.Length];
            int number = int.Parse(inputNumber);

            for (int i = 0; i < arr.Length; i++)
            {
                int lastDigit = number % 10;
                arr[i] = lastDigit;
                number /= 10;
            }

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine(sum);
        }
    }
}
