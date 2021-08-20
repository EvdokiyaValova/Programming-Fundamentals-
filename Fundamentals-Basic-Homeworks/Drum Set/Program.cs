using System;
using System.Collections.Generic;
using System.Linq;

namespace Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split().Select(int.Parse).ToList();

            string comand = Console.ReadLine();

            List<int> resultDrumSets = new List<int>();
            for (int i = 0; i < drumSet.Count; i++)
            {
                resultDrumSets.Add(drumSet[i]);
            }

            int currentDrumSet = 0;
            
            while (comand != "Hit it again, Gabsy!")
            {
                int power = int.Parse(comand);
                List<int> indexForDeleted = new List<int>();
                
                for (int i = 0; i < resultDrumSets.Count; i++)
                {
                    currentDrumSet = resultDrumSets[i] - power;                    

                    if (currentDrumSet <= 0)
                    {
                        int price = drumSet[i] * 3;
                        if (money >= price)
                        {
                            resultDrumSets[i] = currentDrumSet;
                           
                            money -= price;
                        }
                        else
                        {
                            //                           resultDrumSets.RemoveAt(i);
                            indexForDeleted.Add(i);
                        }
                    }
                    else
                    {
                        resultDrumSets[i] = currentDrumSet;

                    }
                    
                }

                for (int i = 0; i < indexForDeleted.Count; i++)
                {
                    resultDrumSets.RemoveAt(indexForDeleted[i]);
                }
                Console.Write(string.Join(" ", resultDrumSets));
               Console.WriteLine();
                comand = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", resultDrumSets));
            Console.WriteLine($"Gabsy has {money:f2}lv.");
        }
    }
}
