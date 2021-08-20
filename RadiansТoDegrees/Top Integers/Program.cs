using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                bool isBigger = false;
                if (i == inputNumbers.Length - 1)
                {
                    Console.Write(inputNumbers[i]);
                    break;
                }

                for (int j = i+1; j < inputNumbers.Length; j++)
                {
                    if (inputNumbers[i] > inputNumbers[j])
                    {
                        isBigger = true;
                    }
                    else
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger == true)
                {
                    Console.Write(inputNumbers[i] + " ");
                }
                
            }
        }
    }
}
