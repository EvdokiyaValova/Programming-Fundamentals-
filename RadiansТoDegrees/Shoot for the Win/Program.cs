using System;
using System.Collections.Generic;
using System.Linq;

namespace Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targetSequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            string comand = Console.ReadLine();

            int countTarget = 0;

            while (comand != "End")
            {
                int indexOfTheTarget = int.Parse(comand);

                if (indexOfTheTarget >= 0 && indexOfTheTarget < targetSequence.Count)
                {
                    if (targetSequence[indexOfTheTarget] != -1)
                    {
                        int currentTarget = targetSequence[indexOfTheTarget];
                        targetSequence[indexOfTheTarget] = -1;
                        countTarget ++;

                        for (int i = 0; i < targetSequence.Count; i++)
                        {
                            if (targetSequence[i] <= currentTarget)
                            {
                                if (targetSequence[i] != -1)
                                {
                                    targetSequence[i] += currentTarget;
                                }
                                
                            }
                            else if (targetSequence[i] > currentTarget)
                            {
                                if (targetSequence[i] != -1)
                                {
                                    targetSequence[i] -= currentTarget;
                                }
                            }
                        }
                    }
                }
                comand = Console.ReadLine();
            }

            Console.Write($"Shot targets: {countTarget} -> ");
            Console.WriteLine(string.Join(" ", targetSequence));
        }
    }
}
