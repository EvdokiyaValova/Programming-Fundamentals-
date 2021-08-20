using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rasers = Console.ReadLine().Split(", ");

            string name = "[A-Za-z]";
            string digit = "[0-9]";
            Dictionary<string, int> participans = new Dictionary<string, int>();

            foreach (var item in rasers)
            {
                participans.Add(item, 0);
            }

            string line = Console.ReadLine();

            while (line != "end of race")
            {

                string currentName = string.Empty;
                MatchCollection letters = Regex.Matches(line, name);

                foreach (Match letter in letters)
                {
                    currentName += letter.Value;
                }

                if (!participans.ContainsKey(currentName))
                {
                    line = Console.ReadLine();
                    continue;
                }

                int currentSum = 0;
                MatchCollection digits = Regex.Matches(line, digit);

                foreach (Match currentDigit in digits)
                {
                    currentSum += int.Parse(currentDigit.Value);
                }

                participans[currentName] += currentSum;

                line = Console.ReadLine();
            }


            int counter = 1;

            foreach (var kvp in participans.OrderByDescending(x => x.Value))
            {
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {kvp.Key}");
                    counter++;
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {kvp.Key}");
                    counter++;
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {kvp.Key}");
                    counter++;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
