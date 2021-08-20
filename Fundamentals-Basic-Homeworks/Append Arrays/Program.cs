using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<List<int>> numbers = new List<List<int>>();

            List<string> current = input
                  .Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = current.Count - 1; i >= 0; i--)
            {
                numbers.Add(new List<int>());

            }

            for (int i = current.Count - 1; i >= 0; i--)
            {
                numbers[i] = current[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            }


            for (int row = numbers.Count - 1; row >= 0; row--)
            {
                for (int col = 0; col < numbers[row].Count; col++)
                {
                    Console.Write(numbers[row][col] + " ");
                }
            }

        }
    }
}
