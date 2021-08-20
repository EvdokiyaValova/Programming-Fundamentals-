using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int countTargets = 0;
            int currentPower = pokePower;
            
            while (currentPower >= distance)
            {
                currentPower -= distance;
                countTargets ++;

                if (currentPower == (pokePower /2) && exhaustionFactor > 0)
                {
                    currentPower /= exhaustionFactor;
                }

            }

                Console.WriteLine(currentPower);
                Console.WriteLine(countTargets);
                        
        }
    }
}
