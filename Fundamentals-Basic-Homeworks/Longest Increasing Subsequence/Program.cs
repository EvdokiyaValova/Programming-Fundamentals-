using System;
using System.Collections.Generic;
using System.Linq;

namespace Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> current = new List<int>();
            for (int i = line.Length - 1; i > 0; i--)
            {       
                if (line[i] > line[i - 1])
                {
                    current.Add(line[i]);
                }
            }

            Console.WriteLine(string.Join(" ", current));
        }
    }
}
