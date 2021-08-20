using System;
using System.Collections.Generic;
using System.Linq;

namespace Heart_Delivery2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToList();
            string input = Console.ReadLine();
            int index = 0;
            while (input != "Love!")
            {
                string[] comand = input.Split().ToArray();
                int jump = int.Parse(comand[1]);
                index += jump;
                if (index >= neighborhood.Count)
                {
                    index = 0;
                }

                if (neighborhood[index] == 0)
                {
                    Console.WriteLine($"Place {index} already had Valentine's day.");
                    input = Console.ReadLine();
                    continue;
                }
                neighborhood[index] -= 2;
                if (neighborhood[index] <= 0)
                {
                    Console.WriteLine($"Place {index} has Valentine's day.");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {index}.");

            bool isValantine = true;
            int count = 0;
            for (int i = 0; i < neighborhood.Count; i++)
            {
                if (neighborhood[i] >0)
                {
                    isValantine = false;
                    count ++;
                }
            }

            if (isValantine == true)
            {
                Console.WriteLine("Mission was successful.");
            }
            if (isValantine == false)
            {
                Console.WriteLine($"Cupid has failed {count} places.");
            }
            
        }
    }
}
