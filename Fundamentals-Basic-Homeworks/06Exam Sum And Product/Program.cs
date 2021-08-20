using System;

namespace _06Exam_Sum_And_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // int[] number = {a + b + c + d };

            int number = 0;
            bool isFinished = false;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 9; b >= a; b--)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 9; d >= c; d--)
                        {
                            if ((a+b+c+d) == (a*b*c*d) && n % 10 == 5)
                            {
                                number = a * 1000 + b * 100 + c * 10 + d;
                                isFinished = true;
                                break;
                            }
                            else if (a*b*c*d / (a+b+c+d) == 3 && n % 3 == 0)
                            {
                                number = d*1000 + c * 100 + b * 10 + a;
                                isFinished = true;
                                break;
                            }
                        }
                        if (isFinished)
                            break;
                    }
                    if (isFinished)
                        break;
                }
                if (isFinished)
                    break;
            }

            if (isFinished)
                Console.WriteLine(number);
            else
                Console.WriteLine("Nothing found");
        }
    }
}
