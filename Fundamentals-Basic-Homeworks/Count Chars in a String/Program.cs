using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {            
            Dictionary<char, int> count = new Dictionary<char, int>();

            string word = Console.ReadLine();

            foreach (char letter in word)
            {
                if (letter == ' ')
                {
                    continue;
                }

                if (count.ContainsKey(letter))
                {
                    count[letter]++; 
                }
                else
                {
                    count.Add(letter, 1);
                }
            }

            foreach (var kvp in count)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
