using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, int> materials = new Dictionary<string, int> 
            {
                {"shards", 0},
                {"fragments", 0},
                {"motes", 0}
            };
            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();

            bool collected = false;
            string legendaryElement = "";

            while (!collected)
            {
                string[] elements = Console.ReadLine().Split();

                for (int i = 0; i < elements.Length - 1; i+=2)
                {
                    int quantity = int.Parse(elements[i]);
                    string item = elements[i + 1].ToLower();

                    if (materials.ContainsKey(item))
                    {
                        materials[item] += quantity;

                        if (materials[item] >= 250)
                        {
                            collected = true;
                            legendaryElement = item;
                            materials[item] -= 250;
                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(item))
                        {
                            junk[item] += quantity;
                            
                        }
                        else
                        {
                            junk.Add(item, quantity);
                        }

                        
                    }
                }
            }

            if (collected)
            {
                if (legendaryElement == "shards")
                {
                    Console.WriteLine("Shadowmourne obtained!");
                }
                else if (legendaryElement == "fragments")
                {
                    Console.WriteLine("Valanyr obtained!");
                }
                else if (legendaryElement == "motes")
                {
                    Console.WriteLine("Dragonwrath obtained!");
                }
            }

            Dictionary<string, int> sortedMaterials = materials
                .OrderByDescending(i => i.Value)
                .ThenBy(i => i.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
