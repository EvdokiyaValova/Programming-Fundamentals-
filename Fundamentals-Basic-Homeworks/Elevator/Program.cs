using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityElevator = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling(numberOfPeople * 1.0 / capacityElevator);

            Console.WriteLine(courses);
        }
    }
}
