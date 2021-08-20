using System;

namespace National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int numberPeople = int.Parse(Console.ReadLine());

            int perOneHourPeople = firstEmployee + secondEmployee + thirdEmployee;
            int countWorkTime = 0;
                        
            while (numberPeople > 0)
            {
                numberPeople -= perOneHourPeople;                
                countWorkTime++;

                if (countWorkTime % 4 == 0)
                {
                    countWorkTime++;
                }
                
            }

            Console.WriteLine($"Time needed: {countWorkTime}h.");
        }
    }
}
