using System;
using System.Collections.Generic;

namespace Count_Chars_in_a_String2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    continue;
                }
                else if (charCount.ContainsKey(input[i]) == false)
                {
                    charCount.Add(input[i], 0);
                }

                charCount[input[i]]++;
            }

            foreach (var kvp in charCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
