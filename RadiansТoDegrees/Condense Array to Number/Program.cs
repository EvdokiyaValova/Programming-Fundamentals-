using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            
                        

            while (numbersArray.Length > 1)
            {
                int[] condensedArray = new int[numbersArray.Length - 1];

                for (int i = 0; i < numbersArray.Length - 1; i++)
                {                    
                    condensedArray[i] = numbersArray[i] + numbersArray[i + 1];
                }

                numbersArray =  condensedArray;
            }

            Console.WriteLine(string.Join(" ", numbersArray));
        }
    }
}
