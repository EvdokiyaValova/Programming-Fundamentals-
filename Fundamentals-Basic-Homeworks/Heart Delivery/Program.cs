using System;
using System.Collections.Generic;
using System.Linq;

namespace Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToList();            
            string[] currentJump = Console.ReadLine().Split().ToArray();

            int indexCupid = 0;
            int lenghtList = neighborhood.Count;

//            List<bool> visited = new List<bool>();
 //           for (int i = 0; i < neighborhood.Count; i++)
  //          {
  //              visited.Add(false);
 //           }
                      
            while (currentJump[0] != "Love!")
            {
                int step = int.Parse(currentJump[1]);

                indexCupid += step;

                if (indexCupid < 0 || indexCupid >= neighborhood.Count)
                {
                    indexCupid = 0;
                }

 //               visited[indexCupid] = true;

                if (indexCupid >= 0 && indexCupid < neighborhood.Count)
                {
                    if (neighborhood[indexCupid] == 0)
                    {
                        Console.WriteLine($"Place {indexCupid} already had Valentine's day.");
                        currentJump = Console.ReadLine().Split().ToArray();
                        continue;
                    }

                    neighborhood[indexCupid] -= 2;

                    if (neighborhood[indexCupid] == 0)
                    {
                        Console.WriteLine($"Place {indexCupid} has Valentine's day.");
                    }
                }

                currentJump = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine($"Cupid's last position was {indexCupid}.");

            int countDoNotValentine = 0;
            for (int i = 0; i < neighborhood.Count; i++)
            {
                if (neighborhood[i] > 0)
                {
                    countDoNotValentine++;
                }
            }

            if (countDoNotValentine == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {countDoNotValentine} places.");
            }
            
            
        }
    }
}
