using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstGamester = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondGamster = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
           
            while (firstGamester.Count > 0 && secondGamster.Count > 0)
            {
                int currendCardFirst = firstGamester[0];
                int currendCardSecond = secondGamster[0];

                if (currendCardFirst < currendCardSecond)
                {
                    secondGamster.Add(currendCardSecond);
                    secondGamster.Add(currendCardFirst);
                    firstGamester.RemoveAt(0);
                    secondGamster.RemoveAt(0);
                }
                else if (currendCardFirst == currendCardSecond)
                {
                    firstGamester.RemoveAt(0);
                    secondGamster.RemoveAt(0);
                }
                else if (currendCardFirst > currendCardSecond)
                {
                    firstGamester.Add(currendCardFirst);
                    firstGamester.Add(currendCardSecond);
                    firstGamester.RemoveAt(0);
                    secondGamster.RemoveAt(0);
                }
            }
            

            int sumFirstGamester = 0;
            for (int i = 0; i < firstGamester.Count; i++)
            {
                sumFirstGamester += firstGamester[i];                
            }

            int sumSecondGamester = 0;
            for (int i = 0; i < secondGamster.Count; i++)
            {
                sumSecondGamester += secondGamster[i];
            }

            if (sumFirstGamester > sumSecondGamester)
            {
                Console.WriteLine($"First player wins! Sum: {sumFirstGamester}");
            }
            else if (sumFirstGamester < sumSecondGamester)
            {
                Console.WriteLine($"Second player wins! Sum: {sumSecondGamester}");
            }
        }
    }
}
