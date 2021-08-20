using System;

namespace Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudent = int.Parse(Console.ReadLine());
            int countLecturesInCourse = int.Parse(Console.ReadLine());
            int initalBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            int studentAttendances = 0;

            for (int i = 1; i <= countStudent; i++)
            {
                int attendancesForEachStudent = int.Parse(Console.ReadLine());

                double currentBonus = ((double)attendancesForEachStudent / countLecturesInCourse) * (5 + initalBonus) ;

                if (currentBonus > maxBonus)
                {
                    maxBonus = currentBonus;
                    studentAttendances = attendancesForEachStudent;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {studentAttendances} lectures.");
        }
    }
}
