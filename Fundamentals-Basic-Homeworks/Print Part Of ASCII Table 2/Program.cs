using System;

namespace Print_Part_Of_ASCII_Table_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            char[] letters = new char[endNumber - startNumber +1];

            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = Convert.ToChar(startNumber);
                startNumber++;
            }

            for (int i = 0; i < letters.Length; i++)
            {
                Console.Write(letters[i] + " ");
            }
        }
    }
}
