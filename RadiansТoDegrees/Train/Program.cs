using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string[] comand = Console.ReadLine()
                .Split();

            while (comand[0] != "end")
            {
                
                if (comand[0] == "Add")
                {
                    int passengers = int.Parse(comand[1]);
                    wagons.Add(passengers);
                }
                else 
                {
                    int passengers = int.Parse(comand[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers > maxCapacity)
                        {
                            continue;
                        }
                        else
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
                comand = Console.ReadLine()
                    .Split();
            }

            Console.WriteLine(string.Join(" ",wagons));

        }

    }

}
