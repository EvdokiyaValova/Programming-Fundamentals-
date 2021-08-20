using System;

namespace Town_Info_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] townInfo = new string[3];

            for (int i = 0; i < townInfo.Length; i++)
            {
                townInfo[i] = Console.ReadLine();
            }

            Console.WriteLine($"Town {townInfo[0]} has population of {townInfo[1]} and area {townInfo[2]} square km.");
        }
    }
}
