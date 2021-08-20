using System;

namespace Lower_or_Upper_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char currentChar = Convert.ToChar(Console.ReadLine());

            if ((int)currentChar >= 65 && (int)currentChar <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if ((int)currentChar >= 97 && (int)currentChar <= 122)
            {
                Console.WriteLine("lower-case");
            }
            
        }
    }
}
