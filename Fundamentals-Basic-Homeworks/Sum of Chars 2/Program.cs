using System;

namespace Sum_of_Chars_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            char[] letters = new char[numberOfLines];

            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = char.Parse(Console.ReadLine());
            }

            int sum = 0;

            for (int i = 0; i < letters.Length; i++)
            {
                sum += letters[i];
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
