using System;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] fourKLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int[] firstLine = new int[fourKLine.Length / 2];
            int[] secondLine = new int[fourKLine.Length / 2];

            for (int i = 0; i < fourKLine.Length /2; i++)
            {
                secondLine[i] = fourKLine[fourKLine.Length / 4 + i];
                Console.Write(secondLine[i]);
            }
            Console.WriteLine();

            int[] firsQuarter = new int[fourKLine.Length / 4];
            int howSoFar = 0;

            for (int i = fourKLine.Length / 4 - 1; i >= 0; i--)
            {
                howSoFar++;
                firsQuarter[i] = fourKLine[i];
                Console.Write(firsQuarter[i]);
            }
            Console.WriteLine();

            int[] secondQuarter = new int[fourKLine.Length / 4];

            for (int i = fourKLine.Length - 1; i >= 3 * fourKLine.Length / 4 ; i--)
            {
                secondQuarter[fourKLine.Length - 1 - i - howSoFar] = fourKLine[i];
                Console.Write(secondQuarter[i]);
            }
            Console.WriteLine();

        }
    }
}
