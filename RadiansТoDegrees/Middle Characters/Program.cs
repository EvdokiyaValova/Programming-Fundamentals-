using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            IsMiddleCharactres(text);
        }

        private static void IsMiddleCharactres(string text)
        {
            int middleIndex = text.Length / 2;

            if (text.Length % 2 == 0)
            {
                char middleCharOne = text[text.Length / 2 - 1];
                char middleCharTwo = text[text.Length / 2];

                Console.WriteLine($"{middleCharOne}{middleCharTwo}");
            }
            else
            {
                char middleChar = text[text.Length / 2];

                Console.WriteLine(middleChar);
            }
        }
    }
}
