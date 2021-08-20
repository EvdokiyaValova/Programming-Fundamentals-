using System;
using System.Linq;

namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool sumIsEquals = false;
            
                        
            for (int i = 0; i < inputArr.Length; i++)
            {
                int leftSum = 0;
                int raightSum = 0;
                if ( i== 0)
                {
                    leftSum = 0;
                }
                if (i == inputArr.Length - 1)
                {
                    raightSum = 0;
                }

                for (int j = 0; j < i; j++)
                {
                    leftSum += inputArr[j];
                }

                for (int j = i+1; j < inputArr.Length; j++)
                {
                    raightSum += inputArr[j];
                }

                if (leftSum == raightSum)
                {
                    Console.WriteLine(i);
                    sumIsEquals = true;
                }                
            }

            if (!sumIsEquals)
            {
                Console.WriteLine("no");
            }
        }
    }
}
