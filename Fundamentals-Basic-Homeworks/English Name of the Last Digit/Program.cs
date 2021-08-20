using System;

namespace English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int originalNumber = number;

            int LastDigit = number % 10;

            if (LastDigit == 0)
            {
                Console.WriteLine("zero");
            }
            else if (LastDigit == 1)
            {
                Console.WriteLine("one");
            }
            else if (LastDigit == 2)
            {
                Console.WriteLine("two");
            }
            else if (LastDigit == 3)
            {
                Console.WriteLine("three");
            }
            else if (LastDigit == 4)
            {
                Console.WriteLine("four");
            }
            else if (LastDigit == 5)
            {
                Console.WriteLine("five");
            }
            else if (LastDigit == 6)
            {
                Console.WriteLine("six");
            }
            else if (LastDigit == 7)
            {
                Console.WriteLine("seven");
            }
            else if (LastDigit == 8)
            {
                Console.WriteLine("eight");
            }
            else if (LastDigit == 9)
            {
                Console.WriteLine("nine");
            }
        }
    }
}
