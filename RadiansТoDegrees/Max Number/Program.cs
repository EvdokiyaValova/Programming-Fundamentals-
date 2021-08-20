using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int bigger = int.MinValue;

            while (input != "Stop")
            {
                int currentNumber = int.Parse(input);

                if (currentNumber > bigger)
                {
                    bigger = currentNumber;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(bigger);
        }
    }
}
