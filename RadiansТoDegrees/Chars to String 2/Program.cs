using System;

namespace Chars_to_String_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] charToString = new string[3];

            for (int i = 0; i < charToString.Length; i++)
            {
                charToString[i] = Console.ReadLine();
            }

            for (int i = 0; i < charToString.Length; i++)
            {
                Console.Write(charToString[i]);
            }
        }
    }
}
