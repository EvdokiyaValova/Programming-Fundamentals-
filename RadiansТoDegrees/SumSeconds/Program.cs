using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totallTime = firstTime + secondTime + thirdTime;

            int minute = totallTime / 60;
            int second = totallTime % 60;

            Console.WriteLine($"{minute}:{second:D2}");
        }
    }
}
