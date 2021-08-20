using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> gradeByStudents = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!gradeByStudents.ContainsKey(name))
                {
                    gradeByStudents.Add(name, new List<double>());
                }

                gradeByStudents[name].Add(grade);
            }

            Dictionary<string, List<double>> sortedGradeAverage = gradeByStudents
                .Where(s => s.Value.Average() >= 4.5)
                .OrderByDescending(s => s.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedGradeAverage)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
            }
        }
    }
}
