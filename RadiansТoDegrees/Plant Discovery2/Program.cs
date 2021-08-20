using System;
using System.Collections.Generic;
using System.Linq;

namespace Plant_Discovery2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictPlantRarity = new Dictionary<string, double>();
            var dictPlantRating = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->").ToArray();

                string plant = input[0];
                double rarity = double.Parse(input[1]);

                if (!dictPlantRarity.ContainsKey(plant))
                {
                    dictPlantRarity[plant] = rarity;
                    dictPlantRating[plant] = new List<double>();
                }
                else if (dictPlantRarity.ContainsKey(plant))
                {
                    dictPlantRarity[plant] = rarity;
                }
            }



            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] commandArray = command.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string todo = commandArray[0];
                string[] rightPartOfCommand = commandArray[1].Trim().Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string plant = rightPartOfCommand[0].Trim();

                if (!dictPlantRarity.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                    continue;
                }

                if (todo == "Rate")
                {
                    double rating = double.Parse(rightPartOfCommand[1].Trim());
                    dictPlantRating[plant].Add(rating);

                }
                else if (todo == "Update")
                {
                    double newRarity = double.Parse(rightPartOfCommand[1].Trim());
                    dictPlantRarity[plant] = newRarity;
                }
                else if (todo == "Reset")
                {
                    dictPlantRating[plant].Clear();
                }
                else
                {
                    Console.WriteLine("error");
                }
            }


            var sortedDic = new Dictionary<string, List<double>>();

            foreach (var item in dictPlantRarity)
            {
                sortedDic.Add(item.Key, new List<double>());
                sortedDic[item.Key].Add(item.Value);

                double average = 0;

                if (dictPlantRating[item.Key].Count != 0)
                {
                    average = dictPlantRating[item.Key].Average();
                }
                sortedDic[item.Key].Add(average);
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var item in sortedDic.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]))
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value[0]}; Rating: {item.Value[1]:f2}");
            }

        }
    }
}
