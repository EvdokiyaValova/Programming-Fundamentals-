using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                string reversString = "";

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversString += input[i];
                }

                Console.WriteLine(IsPalindrome(input, reversString));
                input = Console.ReadLine();
            }
        }

         static bool IsPalindrome(string input, string reversString)
        {
            bool isPalindrome = false;
            if (input == reversString)
            {
                isPalindrome = true;
                return isPalindrome;
            }
            return isPalindrome;
        }
    }
}
