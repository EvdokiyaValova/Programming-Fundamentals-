using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int currenElement = inputArr[0];
            int sum = 0;
            int maxSum = 0;
            int maxElement = 0;

            for (int i = 1; i < inputArr.Length; i++)
            {
                if (currenElement == inputArr[i])
                {
                    sum++;
                }
                else
                {
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxElement = currenElement;
                    }
                    sum = 0;
                    currenElement = inputArr[i];
                }
            }

            if (sum > maxSum)
            {
                maxSum = sum;
                maxElement = currenElement;
            }

            int[] resultArr = new int[maxSum +1];
            for (int i = 0; i < resultArr.Length; i++)
            {
                resultArr[i] = maxElement;
            }

            foreach (var number in resultArr)
            {
                Console.Write(number + " ");
            }
        }
    }
}
