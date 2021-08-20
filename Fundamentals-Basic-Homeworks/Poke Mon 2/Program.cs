using System;

namespace Poke_Mon_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int counterTargets = 0;
            int startPokePower = pokePower;

            while (pokePower >= distance)
            {
                counterTargets++;
                pokePower -= distance;
                if (pokePower * 2 == startPokePower && exhaustionFactor > 0)
                {                    
                 pokePower /= exhaustionFactor;                    
                }                       
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(counterTargets);
        }
    }
}
