﻿using System;
using System.Linq;

namespace Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (number == inputArray[i] + inputArray [j])
                    {
                        Console.WriteLine(inputArray[i]+ " " + inputArray[j]);
                    }
                }
            }
        }
    }
}
