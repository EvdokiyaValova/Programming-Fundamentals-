using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        private static readonly int temp;

        static void Main(string[] args)
        {
            int[] arrNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberRotations = int.Parse(Console.ReadLine());

            int[] currentArr = new int[arrNumbers.Length];
            

            for (int i = 0; i < currentArr.Length; i++)
            {
                currentArr[i] = arrNumbers[i];                
            }            

            for (int i = 0; i < numberRotations; i++)                
            {
                int temp = currentArr[0];
                for (int j = 0; j < currentArr.Length -1; j++)
                {                    
                   currentArr[j] = currentArr[j + 1]; 
                }
                currentArr[currentArr.Length - 1] = temp;                
            }

            for (int i = 0; i < currentArr.Length; i++)
            {
                Console.Write(currentArr[i] + " ");
            }
        }
    }
}
