using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            VowelsCount(text);
        }

        private static void VowelsCount(string text)
        {
            int countVowels = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'o' || text[i] == 'u' || text[i] == 'e' || text[i] == 'i' 
                    || text[i] == 'A' || text[i] == 'O' || text[i] == 'U' || text[i] == 'E' || text[i] == 'I')
                {
                    countVowels++;
                }
            }
            Console.WriteLine(countVowels);
        }
    }
}
