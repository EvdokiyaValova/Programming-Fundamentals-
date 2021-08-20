using System;

namespace Reversed_Chars_2
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string[] toChar = new string[3];
            for (int i = 0; i < 3; i++)
            {
                toChar[i] = Console.ReadLine();
            }

            for (int i = toChar.Length -1; i >= 0; i--)
            {
                Console.Write(toChar[i] + " ");
            }
        }
    }
}
