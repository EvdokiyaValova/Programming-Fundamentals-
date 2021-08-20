using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            int[] firstArr = new int[numberLines];
            int[] secondArr = new int[numberLines];

            bool first = false;
            bool second = true;
            string input = Console.ReadLine();

            for (int i = 0; i < numberLines; i++)
            {
                int[] inputLine = input.Split().Select(int.Parse).ToArray();

                    if (first == false && second == true)
                    {
                        firstArr[i] =  inputLine[0];
                        secondArr[i] = inputLine[1];
                        first = true;
                        second = false;
                    }
                    else if (first == true && second == false)
                    {
                        firstArr[i] = inputLine[1];
                        secondArr[i] = inputLine[0];
                        first = false;
                        second = true;
                    }
              

                input = Console.ReadLine();
            }

            for (int i = 0; i < firstArr.Length; i++)
            {
                Console.Write(firstArr[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < secondArr.Length; i++)
            {
                Console.Write(secondArr[i] + " ");
            }

        }
    }
}
