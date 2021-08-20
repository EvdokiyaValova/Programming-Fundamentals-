using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequenceOfTargets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] comand = Console.ReadLine().Split().ToArray();

            while (comand[0] != "End")
            {
                Shoot(sequenceOfTargets, comand);

                Add(sequenceOfTargets, comand);

                Strike(sequenceOfTargets, comand);

                comand = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join("|", sequenceOfTargets));
        }

        private static void Strike(List<int> sequenceOfTargets, string[] comand)
        {
            if (comand[0] == "Strike")
            {
                int index = int.Parse(comand[1]);
                int radius = int.Parse(comand[2]);

                if (index >= 0 && index < sequenceOfTargets.Count)
                {
                    if (index - radius < 0 || index + radius >= sequenceOfTargets.Count)
                    {
                        Console.WriteLine("Strike missed!");
                    }
                    else
                    {
                        for (int i = index + radius; i >= index - radius; i--)
                        {
                            if (i >= 0 && i < sequenceOfTargets.Count)
                            {
                                sequenceOfTargets.RemoveAt(i);
                            }
                            
                        }
                    }

                }
            }
        }

        private static void Add(List<int> sequenceOfTargets, string[] comand)
        {
            if (comand[0] == "Add")
            {
                int index = int.Parse(comand[1]);
                int value = int.Parse(comand[2]);

                if (index >= 0 && index < sequenceOfTargets.Count)
                {
                    sequenceOfTargets.Insert(index, value);
                }
                else
                {
                    Console.WriteLine("Invalid placement!");
                }
            }
        }

        private static void Shoot(List<int> sequenceOfTargets, string[] comand)
        {
            if (comand[0] == "Shoot")
            {
                int index = int.Parse(comand[1]);
                int power = int.Parse(comand[2]);

                if (index >= 0 && index < sequenceOfTargets.Count)
                {
                    sequenceOfTargets[index] -= power;

                    if (sequenceOfTargets[index] <= 0)
                    {
                        sequenceOfTargets.RemoveAt(index);
                    }
                }
            }
        }
    }
}
