using System;
using System.Collections.Generic;
using System.Linq;

namespace Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialTreasureChest = Console.ReadLine().Split("|").ToList();
            List<string> comand = Console.ReadLine().Split().ToList();

            while (comand[0] != "Yohoho!")
            {
                Loot(initialTreasureChest, comand);

                Drop(initialTreasureChest, comand);

                Steal(initialTreasureChest, comand);

                comand = Console.ReadLine().Split().ToList();
            }           

            if (initialTreasureChest.Count > 0)
            {
                int sumElements = 0;
                for (int i = 0; i < initialTreasureChest.Count; i++)
                {
                    string currentElement = initialTreasureChest[i];
                    sumElements += currentElement.Length;
                }

                double average = (double)sumElements / initialTreasureChest.Count;

                Console.WriteLine($"Average treasure gain: {average:f2} pirate credits.");
            }
            else if (initialTreasureChest.Count <= 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }

   //         Console.WriteLine(string.Join(", ", initialTreasureChest));
        }

        private static void Steal(List<string> initialTreasureChest, List<string> comand)
        {
            if (comand[0] == "Steal")
            {
                int count = int.Parse(comand[1]);
                List<string> stealElements = new List<string>();

                if (count > initialTreasureChest.Count)
                {
                    count = initialTreasureChest.Count;               
                }
                
                if (count <= initialTreasureChest.Count)
                {
                    for (int i = initialTreasureChest.Count - count; i < initialTreasureChest.Count; i++)
                    {
                        stealElements.Add(initialTreasureChest[i]);
                        initialTreasureChest[i] = "@";
                    }   
                    initialTreasureChest.RemoveAll(x => x == "@");

                    Console.WriteLine(string.Join(", ", stealElements));
                }
            }
        }

        private static void Drop(List<string> initialTreasureChest, List<string> comand)
        {
            if (comand[0] == "Drop")
            {
                int index = int.Parse(comand[1]);

                if (index >= 0 && index < initialTreasureChest.Count)
                {
                    string temp = initialTreasureChest[index];
                    initialTreasureChest.Add(temp);
                    initialTreasureChest.RemoveAt(index);
                }
            }
        }

        private static void Loot(List<string> initialTreasureChest, List<string> comand)
        {
            if (comand[0] == "Loot")
            {
                for (int i = 1; i < comand.Count; i++)
                {
                    bool isHave = false;

                    for (int j = 0; j < initialTreasureChest.Count; j++)
                    {
                        if (comand[i] == initialTreasureChest[j])
                        {
                            isHave = true;
                        }
                    }

                    if (isHave == false)
                    {
                        initialTreasureChest.Insert(0, comand[i]);
                    }
                }
            }
        }
    }
}
