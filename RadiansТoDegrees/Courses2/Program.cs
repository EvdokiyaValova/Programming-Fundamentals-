using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> register = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] currentData = Console.ReadLine().Split(" : ").ToArray();

                if (currentData[0] == "end")
                {
                    break;
                }

                string course = currentData[0];
                string student = currentData[1];

                if (!register.ContainsKey(course))
                {
                    register.Add(course, new List<string>());
                }

                register[course].Add(student);
            }

            Dictionary<string, List<string>> sortedRegister = register
                .OrderByDescending(c => c.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedRegister)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                kvp.Value.Sort();

                foreach (var student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
