using System;
using System.Collections.Generic;
using System.Linq;

namespace Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // {plant}<->{rarity}

            Dictionary<string, double> plantsRarity = new Dictionary<string, double>();
            Dictionary<string, List<double>> plantsRating = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string plant = input[0];
                double rarity = double.Parse(input[1]);
                    
                if (!plantsRarity.ContainsKey(plant))
                {
                    plantsRarity.Add(plant, rarity);
                    plantsRating.Add(plant, new List<double>());
                }
                else
                {
                    plantsRarity[plant] = rarity;                    
                }                
            }

            while (true)
            {
                string[] currentComand = Console.ReadLine().Split(": ");

                if (currentComand[0] == "Exhibition")
                {
                    break;
                }

                string[] comand = currentComand[1].Split(" - ");                

                if (currentComand[0] == "Rate")
                {
                    // •	Rate: {plant} - {rating} 

                    string plant = comand[0];
                    double rating = double.Parse(comand[1]);

                    if (plantsRarity.ContainsKey(plant))
                    {
                        plantsRating[plant].Add(rating);
                    }
                    else 
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
                else if (currentComand[0] == "Update")
                {
                    // •	Update: {plant} - {new_rarity} 

                    string plant = comand[0];
                    double newRarity = double.Parse(comand[1]);

                    if (plantsRarity.ContainsKey(plant))
                    {
                        plantsRarity[plant] = newRarity;                       
                    }
                    else 
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
                else if (currentComand[0] == "Reset")
                {
                    // •	Reset: {plant} 

                    string plant = comand[0];
                    

                    if (plantsRarity.ContainsKey(plant))
                    {
                        plantsRating[plant].Clear();
                        plantsRating[plant].Add(0); ;
                    }
                    else 
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
            }

            Dictionary<string, double> plantsAverage = new Dictionary<string, double>();

            foreach (var item in plantsRating)
            {
                double sum = 0;
                for (int i = 0; i < item.Value.Count; i++)
                {
                    sum += item.Value[i];
                }

                double average = sum / item.Value.Count;

                plantsAverage.Add(item.Key, average);

            }

            Dictionary<string, List<double>> result = new Dictionary<string, List<double>>();

            foreach (var item in plantsRarity)
            {
                result.Add(item.Key, new List<double>());
                result[item.Key].Add(plantsRarity[item.Key]);
                result[item.Key].Add(plantsAverage[item.Key]);
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in result.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]))
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value[0]}; Rating: {item.Value[1]:f2}");
            }
        }
    }
}
