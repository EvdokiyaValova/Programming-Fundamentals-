using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());

            int totalMinutesExam = hourExam * 60 + minutesExam;
            int totalMinutesArrival = hourArrival * 60 + minutesArrival;
            int result = totalMinutesExam - totalMinutesArrival;

            if (result > 30)
            {
                Console.WriteLine("Early");
                if (result < 60)
                {
                    Console.WriteLine($"{result} minutes before the start");
                }
                else
                {
                    int hour = result / 60;
                    int min = result % 60;
                    Console.WriteLine($"{hour}:{min:D2} hours before the start");
                }
            }
            else if (result >= 0)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{result} minutes before the start");
            }
            else if (result < 0)
            {
                Console.WriteLine("Late");

                if (Math.Abs(result) < 60)
                {
                    Console.WriteLine($"{Math.Abs(result)} minutes after the start");
                }
                else if (Math.Abs(result) >= 60)
                {
                    int hour = Math.Abs(result) / 60;
                    int min = Math.Abs(result) % 60;
                    Console.WriteLine($"{hour}:{min:D2} hours after the start");
                }
            }
        }
    }
}
