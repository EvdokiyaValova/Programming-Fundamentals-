using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                
                for (int j = i; j < numbers.Count; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
                sum += numbers[i];

  //              Console.Write(numbers[i] + " ");
            }
   //             Console.WriteLine();

            double average = (double)sum / numbers.Count;            
            int count = 5;
            bool isBigger = false;

                for (int i = 0; i < numbers.Count; i++)
                {
                   if (count > 0 && numbers[i] > average)
                   {
                    Console.Write(numbers[i] + " ");
                    isBigger = true;
                   }
                count --;
                }

            if (!isBigger)
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
