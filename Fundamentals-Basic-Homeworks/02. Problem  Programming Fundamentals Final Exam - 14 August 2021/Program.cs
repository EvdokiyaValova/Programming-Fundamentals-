using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Problem__Programming_Fundamentals_Final_Exam___14_August_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"!([A-Z][a-z]{3,})!:\[([A-z]{8,})\]";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Regex regex = new Regex(@"!([A-Z][a-z]{3,})!:\[([A-z]{8,})\]");
                Match match = regex.Match(input);
                bool containsValid = regex.IsMatch(input);

                if (!containsValid)
                {
                    Console.WriteLine("The message is invalid");
                }
                else
                {
                    Console.Write($"{match.Groups[1].Value}: ");

                    string message = match.Groups[2].Value;

                    List<int> result = new List<int>();

                    for (int j = 0; j < message.Length; j++)
                    {
                        result.Add(message[j]);
                    }

                    Console.WriteLine(string.Join(" ", result));
                }
            }
        }
    }
}
