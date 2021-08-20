using System;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int smallest = int.MaxValue;

            while (input != "Stop")
            {
                int currentNumber = int.Parse(input);

                if (currentNumber < smallest)
                {
                    smallest = currentNumber;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(smallest);
        }
    }
}
