using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Problem_Programming_Fundamentals_Final_Exam___14_August_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> animalFood = new Dictionary<string, int>();
            Dictionary<string, string> animalArea = new Dictionary<string, string>();

            while (true)
            {
                string[] comand = Console.ReadLine().Split(": ");
                if (comand[0] == "EndDay")
                {
                    break;
                }
                List<string> currentComad = comand[1].Split("-").ToList();
                // Feed: {animalName}-{food}

                if (comand[0] == "Add")
                {
                    if (!animalFood.ContainsKey(currentComad[0]))
                    {
                        animalFood.Add(currentComad[0], int.Parse(currentComad[1]));
                        animalArea.Add(currentComad[0], currentComad[2]);

                      //  Console.WriteLine(string.Join(" ", animalFood));
                      //  Console.WriteLine(string.Join(" ", animalArea));
                    }
                    else
                    {
                        animalFood[currentComad[0]] += int.Parse(currentComad[1]);

                     //   Console.WriteLine(string.Join(" ", animalFood));
                     //   Console.WriteLine(string.Join(" ", animalArea));
                    }
                }
                else if (comand[0] == "Feed")
                {
                    if (!animalFood.ContainsKey(currentComad[0]))
                    {
                        continue;
                    }
                    else
                    {
                        int food = int.Parse(currentComad[1]);
                        animalFood[currentComad[0]] -= food;
                        
                        if (animalFood[currentComad[0]] <= 0)
                        {
                            Console.WriteLine($"{currentComad[0]} was successfully fed");

                            animalFood.Remove(currentComad[0]);
                            animalArea.Remove(currentComad[0]);
                        }
                      //  Console.WriteLine(string.Join(" ", animalFood));
                      //  Console.WriteLine(string.Join(" ", animalArea));
                    }
                    
                }
            }

            Console.WriteLine("Animals:");

            Dictionary<string, int> sortedFood = animalFood
                .OrderByDescending(f => f.Value)
                .ThenBy(f => f.Key)
                .ToDictionary(f => f.Key, f => f.Value);

            foreach (var item in sortedFood)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}g");
            }

            Console.WriteLine("Areas with hungry animals:");

            Dictionary<string, int> areaCount = new Dictionary<string, int>();

            foreach (var item in animalArea)
            {
                if (!areaCount.ContainsKey(item.Value))
                {
                    areaCount.Add(item.Value, 0);
                }
                
                    areaCount[item.Value] +=1;
                             
            }

            areaCount = areaCount.OrderBy(a => a.Key).ToDictionary(a => a.Key, a => a.Value);

            foreach (var item in areaCount)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
