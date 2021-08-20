using System;
using System.Collections.Generic;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string currentKey = Console.ReadLine();
                string currentValue = Console.ReadLine();

                if (synonyms.ContainsKey(currentKey) == false)
                {
                    synonyms.Add(currentKey, new List<string>());
                }

                synonyms[currentKey].Add(currentValue);
            }

            foreach (var kvp in synonyms)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }

        }
    }
}
