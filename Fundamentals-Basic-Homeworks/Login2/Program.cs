using System;

namespace Login2
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = "";

            for (int i = username.Length -1; i >= 0; i--)
            {
                password += username [i];
            }

            string input = Console.ReadLine();
            int counter = 0;
            
            while (input != password)
            {
                string inputPassword = input;
                counter++;

                if (counter < 4)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
               

                input = Console.ReadLine();
            }

            if (input == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
