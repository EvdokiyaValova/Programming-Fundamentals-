using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            CharInRange(firstChar, secondChar);
        }

        private static void CharInRange(char firstChar, char secondChar)
        {
            if (firstChar < secondChar)
            {

              for (char i = (char)(firstChar + 1); i < (char)secondChar; i++)
              {
                Console.Write((char)i + " ");
              }
            }
            else if (firstChar > secondChar)
            {
                for (int i = (char)(secondChar + 1); i < (char)firstChar; i++)
                {
                    Console.Write((char)i + " ");
                }
            }

        }
    }
}
