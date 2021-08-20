using System;

namespace Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneNumber = int.MinValue;
//            int secondNumber = int.MaxValue;
            int thirdNumber = int.MaxValue;
            int sumNumbers = 0;

            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sumNumbers += number;
                
                if (number > oneNumber)
                {
                    oneNumber = number;
                }
                 
                if ( number < thirdNumber)
                {
                    thirdNumber = number;
                }

                
            }

            int secondNumber = sumNumbers - oneNumber - thirdNumber;
            Console.WriteLine(oneNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
        }
    }
}
