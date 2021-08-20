using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int countgWalking = 0;
            bool flag = true;

            while (countgWalking <= 10000)
            {
                
                if (input != "Going home")
                {
                    int walking = int.Parse(input);
                    
                    if (flag == false)
                    {
                        countgWalking += walking;
                        break;
                    }
                    countgWalking += walking;
                }
                else
                {
                    flag = false;
                }
                input = Console.ReadLine();
            }

            if (countgWalking >= 10000)
            {
                int diff = countgWalking - 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{diff} steps over the goal!");

            }
            else
            {
                int diff = 10000 - countgWalking;
                Console.WriteLine($"{diff} more steps to reach goal.");
            }

        }
    }
}
