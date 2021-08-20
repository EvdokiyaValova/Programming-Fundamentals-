using System;
using System.Linq;

namespace From_Left_to_The_Right
{
    class Program
    {
        public static object Mat { get; private set; }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < n; i++)
            {
                long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();

                long maxNumber = 0;
                if (arr[0] >= arr[1])
                {
                    maxNumber = arr[0];
                }
                else if (arr[0] < arr[1])
                {
                    maxNumber = arr[1];
                }

                maxNumber = Math.Abs(maxNumber);

                long sumDigit = 0;
                while (maxNumber > 0)
                {
                    long lastDigit = maxNumber % 10;
                    sumDigit += Math.Abs(lastDigit);
                    maxNumber /= 10;
                }

                Console.WriteLine(sumDigit);

            }
        }
    }
}
