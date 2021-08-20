    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    namespace Destination_Mapper
    {
        class Program
        {
            static void Main(string[] args)
            {
                string text = Console.ReadLine();

              //  string pattern = @"(=|\/)([A-Z][A-Za-z]{3,})\1";

                Regex regex = new Regex(@"(=|\/)(?<location>[A-Z][A-Za-z]{2,})\1");

                MatchCollection matches = regex.Matches(text);

            //    Console.WriteLine(matches.Count);          

                Console.Write("Destinations: ");

                List<string> result = new List<string>();

                foreach (Match match in matches)
                {
                    string current = match.Groups[2].ToString();
                    result.Add(current);
                }

                Console.Write(string.Join(", ", result));
                Console.WriteLine();

                int points = 0;

                for (int i = 0; i < result.Count; i++)
                {
                    points += result[i].Length;
                }

                Console.WriteLine($"Travel Points: {points}");
            }
        }
    }
