using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> result = new List<string>();
            string pattern = @"(@|#)(?<word1>[A-Za-z]{3,})\1{2}(?<word2>[A-Za-z]{3,})\1";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                string wordOne = match.Groups["word1"].Value;
                string wordTwo = match.Groups["word2"].Value;

                string reversedWord = string.Join("", match.Groups["word2"].Value.Reverse());
               
                if (wordOne == reversedWord)
                {
                    result.Add($"{wordOne} <=> {wordTwo}");
                }
            }

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            if (result.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", result));
            }
        }
    }
}
