using System;
using System.Linq;

namespace Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] comand = Console.ReadLine().Split().ToArray();

            while (comand[0] != "end")
            {
                Swap(numbersArray, comand);

                Multiply(numbersArray, comand);

                Decrease(numbersArray, comand);

                comand = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(", ", numbersArray));
        }

        private static void Decrease(int[] numbersArray, string[] comand)
        {
            if (comand[0] == "decrease")
            {
                for (int i = 0; i < numbersArray.Length; i++)
                {
                    numbersArray[i] -= 1;
                }
            }
        }

        private static void Multiply(int[] numbersArray, string[] comand)
        {
            if (comand[0] == "multiply")
            {
                int index1 = int.Parse(comand[1]);
                int index2 = int.Parse(comand[2]);

                numbersArray[index1] *= numbersArray[index2];
            }
        }

        private static void Swap(int[] numbersArray, string[] comand)
        {
            if (comand[0] == "swap")
            {
                int index1 = int.Parse(comand[1]);
                int index2 = int.Parse(comand[2]);

                int temp = numbersArray[index1];
                numbersArray[index1] = numbersArray[index2];
                numbersArray[index2] = temp;
            }
        }
    }
}
