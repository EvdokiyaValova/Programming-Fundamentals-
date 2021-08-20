using System;

namespace _05Exam_Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string bestPlayer = "";
            int maxGoal = 0;

            while (input != "END")
            {
                string playerName = input;
                int numberOfGoals = int.Parse(Console.ReadLine());

                if (numberOfGoals > maxGoal)
                {
                    maxGoal = numberOfGoals;
                    bestPlayer = playerName;                    
                }

                if (numberOfGoals >= 10)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{bestPlayer} is the best player!");
            if (maxGoal >= 3)
            {
                Console.WriteLine($"He has scored {maxGoal} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxGoal} goals.");
            }
        }
    }
}
