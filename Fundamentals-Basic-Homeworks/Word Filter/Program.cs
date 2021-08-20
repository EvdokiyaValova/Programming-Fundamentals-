using System;
using System.Linq;

namespace Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()
                .Split()
                .Where(w => w.Length % 2 == 0)
                .ToArray();

            for (int i = 0; i < line.Length; i++)
            {
                Console.WriteLine(line[i]);
            }
        }
    }
}
