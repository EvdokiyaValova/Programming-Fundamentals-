using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int requiredHours = int.Parse(Console.ReadLine());
            int hasDays = int.Parse(Console.ReadLine());
            int countOvertimeEmployees = int.Parse(Console.ReadLine());

            double workingDays = hasDays * 0.90;
            double workingHour = workingDays * 8;
            double overtimeHour = countOvertimeEmployees * 2 * hasDays;
            double totalWorkingTime = Math.Floor(workingHour + overtimeHour);
            double difference = Math.Abs(totalWorkingTime - requiredHours);

            if (requiredHours <= totalWorkingTime)
            {
                Console.WriteLine($"Yes!{Math.Floor(difference):f0} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Floor(difference):f0} hours needed.");
            }
        }
    }
}
