using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;


namespace _03._Problem_Programming_Fundamentals_Final_Exam___14_August_2021a
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(": ");
            Dictionary<string, int> animalDict = new Dictionary<string, int>();
            Dictionary<string, List<string>> zoneDict = new Dictionary<string, List<string>>();
            string animalZone = "";
            while (command[0] != "EndDay")
            {
                string[] animalActions = command[1].Split("-");
                string animalName = animalActions[0];
                int foodNeeded = int.Parse(animalActions[1]);


                if (command[0] == "Add") // "Add: {animal_name}-{needed_food_quantity}-{area}"
                {
                    animalZone = animalActions[2];
                    if (animalDict.ContainsKey(animalName))
                    {
                        animalDict[animalName] += foodNeeded;
                    }
                    else
                    {
                        animalDict.Add(animalName, foodNeeded);
                    }
                    if (zoneDict.ContainsKey(animalZone) && !zoneDict[animalZone].Contains(animalName))
                    {
                        zoneDict[animalZone].Add(animalName);
                    }
                    else if (!zoneDict.ContainsKey(animalZone))
                    {
                        zoneDict.Add(animalZone, new List<string> { animalName });
                    }


                }
                else if (command[0] == "Feed")
                {
                    if (animalDict.ContainsKey(animalName))
                    {
                        animalDict[animalName] -= foodNeeded;

                        if (animalDict[animalName] <= 0)
                        {
                            animalDict.Remove(animalName);
                            Console.WriteLine($"{animalName} was successfully fed");
                            string zoneKeyFound = "";

                            foreach (var zone in zoneDict)
                            {
                                if (zone.Value.Contains(animalName))
                                {
                                    zoneKeyFound = zone.Key;
                                }
                            }

                            //var myKey = zoneDict.Values.FirstOrDefault(x => x.Value == animalName).Key;
                            zoneDict[zoneKeyFound].Remove(animalName);

                        }
                    }
                }

                command = Console.ReadLine().Split(": ");
            }
            Console.WriteLine("Animals:");

            animalDict = animalDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var animal in animalDict)
            {
                Console.WriteLine($"{animal.Key} -> {animal.Value}g");
            }

            zoneDict = zoneDict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Areas with hungry animals:");

            foreach (var zone in zoneDict)
            {
                if (zone.Value.Count > 0)
                {
                    Console.WriteLine($"{zone.Key}: {zone.Value.Count}");
                }

            }
        }
    }
}
