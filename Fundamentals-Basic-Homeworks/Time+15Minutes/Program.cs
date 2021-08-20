using System;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minuts = int.Parse(Console.ReadLine()) + 15;

            if (minuts >= 60)
            {
                hour++;
                minuts -= 60;
                if (hour >=24)
                {
                    hour = 0;
                }
            }
            

            Console.WriteLine($"{hour}:{minuts:d02}");
        }
    }
}
