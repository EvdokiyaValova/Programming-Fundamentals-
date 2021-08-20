using System;

namespace ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string currentName = input;

                Console.WriteLine(currentName);

                input = Console.ReadLine();
            }
        }
    }
}
