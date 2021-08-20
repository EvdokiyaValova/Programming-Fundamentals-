using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = int.Parse(Console.ReadLine());
            int indexPow = int.Parse(Console.ReadLine());

            double result = NumberPow(number, indexPow);

            Console.WriteLine(result);
        }

         static double NumberPow(double number, int indexPow)
         {
            double result = 1;

            if (indexPow > 0)
            {
                for (int i = 0; i < indexPow; i++)
                {
                    result *= number;
                }
            }
            else if (indexPow == 0)
            {
                result = 1;
            }

            else if (indexPow < 0)
            {
                if (number != 0)
                {
                    for (int i = 0; i < Math.Abs(indexPow); i++)
                    {
                        result *= number;
                    }

                    result = 1 / result;
                }
                else
                {
                    result = 0;
                }
            }

            return result;
        }
    }
}
