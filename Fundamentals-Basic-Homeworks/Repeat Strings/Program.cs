using System;

namespace Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            string newLine = string.Empty;

            foreach (var element in line)
            {
                int longest = element.Length;

                for (int i = 0; i < longest; i++)
                {
                    newLine += element;
                }
            }
            

            Console.WriteLine(newLine);
        }
    }
}
