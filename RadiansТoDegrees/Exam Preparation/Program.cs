using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int unsatisfactoryAssessments = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int numberTask = 0;
            string nameLastTask = "";
            double averageSuccess = 0;
            double currentSuccess = 0;
            int poorGrade = 0;
            bool flag = true;

            while (input != "Enough")
            {
                string nameTask = input;
                int grade = int.Parse(Console.ReadLine());

                nameLastTask = nameTask;

                if (grade <= 4)
                {
                    poorGrade++;

                    if (poorGrade == unsatisfactoryAssessments)
                    {
                        flag = false;
                        Console.WriteLine($"You need a break, {poorGrade} poor grades.");
                        break;
                    }
                }

                numberTask++;
                currentSuccess += grade;

                input = Console.ReadLine();
            }

            if (flag)
            {
                averageSuccess = currentSuccess / numberTask;

                Console.WriteLine($"Average score: {averageSuccess:f2}");
                Console.WriteLine($"Number of problems: {numberTask}");
                Console.WriteLine($"Last problem: {nameLastTask}");
            }
        }
    }
}
