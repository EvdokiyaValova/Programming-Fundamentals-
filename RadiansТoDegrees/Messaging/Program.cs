using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Program
    {
        private static char separators;

        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine().Split().Select(int.Parse).ToList();
            //           List<string> text = Console.ReadLine().Split().ToList();
            List<char> text = Console.ReadLine().ToList();
            

            for (int i = 0; i < numberList.Count; i++)
            {
                int currentNumber = numberList[i];
                int sumDigit = 0;

                while (currentNumber > 0)
                {
                    int currentDigit = currentNumber % 10;
                    sumDigit += currentDigit;
                    currentNumber /= 10;
                }

                int index = sumDigit;
                
                if (index > text.Count)
                {
                    while (index > text.Count)
                    {
                        index -= text.Count;
                    }
                }

                char simbol = text[index];
                int lenghtDeleted = 1;
                text.RemoveAt(index);

                Console.Write(simbol);
            }            
        }       
    }
}
