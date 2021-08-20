using System;

namespace Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int originalNumber = number;
            int sumFactoriel = 0;

            while (number > 0)
            {
                int curentNumber = number % 10;
                int factoriel = 1;

                for (int i = curentNumber; i > 0; i--)
                {
                     factoriel  *= i;
                }

                sumFactoriel += factoriel;        
                number /= 10;
            }

            if (sumFactoriel == originalNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
