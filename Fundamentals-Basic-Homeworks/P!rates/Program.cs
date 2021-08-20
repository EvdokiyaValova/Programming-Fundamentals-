using System;
using System.Collections.Generic;
using System.Linq;

namespace P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> townsPeople = new Dictionary<string, int>();
            Dictionary<string, int> townsGold = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Sail")
                {
                    break;
                }

                List<string> towns = input.Split("||").ToList();
                string town = towns[0];
                int people = int.Parse(towns[1]);
                int gold = int.Parse(towns[2]);

                if (!townsPeople.ContainsKey(towns[0]))
                {
                    townsPeople.Add(towns[0], people);
                    townsGold.Add(towns[0], gold);
                }
                else
                {
                    townsPeople[town] += people;
                    townsGold[town] += gold;
                }
            }

          //  Console.WriteLine(string.Join(" ", townsPeople));
          //  Console.WriteLine(string.Join(" ", townsGold));

            while (true)
            {
                string comand = Console.ReadLine();

                if (comand == "End")
                {
                    break;
                }

                // Plunder=>{town}=>{people}=>{gold}
                List<string> currentComand = comand.Split("=>").ToList();

                if (currentComand[0] == "Plunder")
                {
                    string town = currentComand[1];
                    int peopleKilled = int.Parse(currentComand[2]);
                    int goldStolen = int.Parse(currentComand[3]);

                    if (townsPeople.ContainsKey(town))
                    {
                        townsPeople[town] -= peopleKilled;
                        townsGold[town] -= goldStolen;

                        Console.WriteLine($"{town} plundered! {goldStolen} gold stolen, {peopleKilled} citizens killed.");

                        if (townsPeople[town] <= 0 || townsGold[town] <=0)
                        {
                            townsPeople.Remove(town);
                            townsGold.Remove(town);

                            Console.WriteLine($"{town} has been wiped off the map!");
                        }
                    }
                }
                else if (currentComand[0] == "Prosper")
                {
                    //Prosper=>{town}=>{gold}

                    string town = currentComand[1];
                    int goldAdded = int.Parse(currentComand[2]);

                    if (goldAdded < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    else
                    {
                        if (townsGold.ContainsKey(town))
                        {
                            townsGold[town] += goldAdded;

                            Console.WriteLine($"{goldAdded} gold added to the city treasury. {town} now has {townsGold[town]} gold.");
                        }
                    }
                }
            }

            var sortedTownGold = townsGold
                .OrderByDescending(t => t.Value)
                .ThenBy(t => t.Key)
                .ToDictionary(t => t.Key, t => t.Value);

            Console.WriteLine($"Ahoy, Captain! There are {townsGold.Count} wealthy settlements to go to:");

            foreach (var kvp in sortedTownGold)
            {
                Console.WriteLine($"{kvp.Key} -> Population: {townsPeople[kvp.Key]} citizens, Gold: {kvp.Value} kg");
            }
        }
    }
}
