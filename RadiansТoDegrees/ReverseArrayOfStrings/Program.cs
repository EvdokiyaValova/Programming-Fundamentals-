using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < text.Length /2; i++)
            {
                string oldText = text[i];
                text[i] = text[text.Length - 1 - i];
                text[text.Length - 1 - i] = oldText;
            }
            Console.WriteLine(string.Join(" ", text));
        }
    }
}
