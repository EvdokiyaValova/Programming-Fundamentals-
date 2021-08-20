using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int volume = width * length * height;
            bool flag = true;

            while (input != "Done")
            {
                int numberCartons = int.Parse(input);

                volume -= numberCartons;
                if (volume <= 0)
                {
                    flag = false;
                    Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }

            if (flag)
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }
        }
    }
}
