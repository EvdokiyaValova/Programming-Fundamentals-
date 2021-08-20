using System;
using System.Collections.Generic;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordInLowerCase = word.ToLower();

                if (counts.ContainsKey(wordInLowerCase))
                {
                    counts[wordInLowerCase]++;
                }
                else
                {
                    counts.Add(wordInLowerCase, 1);
                }
            }

            foreach (var kvp in counts)
            {

                if (kvp.Value % 2 == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write(kvp.Key + " ");
                }
            }
        }
    }
}
