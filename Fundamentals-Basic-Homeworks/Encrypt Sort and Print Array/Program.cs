using System;

namespace Encrypt_Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());
            
            int[] ranking = new int[numberLines];
            for (int i = 0; i < numberLines; i++)
            {
               string input = Console.ReadLine();

                int sumInput = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    char currentElement = input[j];
                    int key = 0;
                    
                    if (currentElement == 'a' || currentElement == 'A'
                        || currentElement == 'o' || currentElement == 'O' 
                        || currentElement == 'u' || currentElement == 'U' 
                        || currentElement == 'e' || currentElement == 'E' 
                        || currentElement == 'i' || currentElement == 'I')
                    {
                        key = (int)currentElement * input.Length;
                    }
                    else
                    {
                        key = (int)currentElement / input.Length;
                    }

                    sumInput += key;
                }

                ranking[i] = sumInput; 
            }
 
            for (int i = 0; i < ranking.Length; i++)
            {
                
                for (int j = 0; j < ranking.Length -1; j++)
                {
                    int temp = 0;
                    if (ranking[j] > ranking[j +1])
                    {
                        temp = ranking[j + 1];
                        ranking[j + 1] = ranking[j];
                        ranking[j] = temp;
                    }
                }
                
            }

            for (int i = 0; i < ranking.Length; i++)
            {
                Console.WriteLine(ranking[i]);
            }

        }
    }
}
