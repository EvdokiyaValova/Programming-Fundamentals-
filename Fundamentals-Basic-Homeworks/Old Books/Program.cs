using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            string input = Console.ReadLine();

            int counterBook = 0;
            bool flag = false;

            while (input != "No More Books")
            {
                string currentBook = input;
                
                if (currentBook == favoriteBook)
                {
                    flag = true;
                    break;
                }

                counterBook++;

                input = Console.ReadLine();
            }

            if (flag)
            {
                Console.WriteLine($"You checked {counterBook} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counterBook} books.");
            }
        }
    }
}
