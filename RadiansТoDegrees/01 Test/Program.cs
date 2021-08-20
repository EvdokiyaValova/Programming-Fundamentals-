using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int numberToIncreaseOrDecreaseSource = 0;
            int totalPoints = 0;

            while (input.Count > 0)
            {
                int inputIndex = int.Parse(Console.ReadLine());

                if (inputIndex < 0)
                {
                    numberToIncreaseOrDecreaseSource = input[0];

                    input[0] = input[input.Count - 1];
                }
                else if (inputIndex >= input.Count)
                {
                    numberToIncreaseOrDecreaseSource = input[input.Count - 1];

                    input[input.Count - 1] = input[0];
                }
                else
                {
                    numberToIncreaseOrDecreaseSource = input[inputIndex];

                    input.RemoveAt(inputIndex);
                }

                totalPoints += numberToIncreaseOrDecreaseSource;

                IncreaseDecreaseNumbers(input, numberToIncreaseOrDecreaseSource);
            }

            Console.WriteLine(totalPoints);
        }

        static void IncreaseDecreaseNumbers(List<int> source, int number)
        {
            for (int i = 0; i < source.Count; i++)
            {
                if (source[i] <= number)
                    source[i] += number;
                else
                    source[i] -= number;
            }
        }
    }
}
