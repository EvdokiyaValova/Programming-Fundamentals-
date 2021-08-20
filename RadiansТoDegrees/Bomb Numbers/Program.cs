using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] bomb = (int[])Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int indexBomb = 0;
            int bombCordinates = bomb[0];
            int power = bomb[1];
  //          List<int> indexesBomb = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {                
                if (numbers[i] == bombCordinates)
                {
                    for (int j = i-power; j <= i + power; j++)
                    {
                        if (j < 0 || j > numbers.Count)
                        {
                            continue;
                        }

                        numbers[j] = 0;
                    }
                }
            }

            int sumNumbers = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sumNumbers += numbers[i];
            }

            Console.WriteLine(sumNumbers);
        }
    }
}
