using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<double>());
                }

                students[studentName].Add(grade);
            }

            //Dictionary<string, List<double>> sortedStudets = students
            //    .Where(s => s.Value.Average() >= 4.5)
            //    .OrderByDescending(s => s.Value.Average())
            //    .ToDictionary(x => x.Key, x => x.Value);

            Dictionary<string, double> sortedStudets = students
                .Select(s => new KeyValuePair<string, double>(s.Key, s.Value.Average()))
               .Where(s => s.Value >= 4.5)
               .OrderByDescending(s => s.Value)
               .ToDictionary(x => x.Key, x => x.Value);

            foreach (var student in sortedStudets)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
