using System;

namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEnergy = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            int wonBattle = 0;
            bool doNotEnergy = false;

            while (comand != "End of battle")
            {
                int distance = int.Parse(comand);

                if (distance > firstEnergy)
                {
                    doNotEnergy = true;
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattle} won battles and {firstEnergy} energy");
                    break;
                }
                else
                {
                    firstEnergy -= distance;
                    wonBattle ++;
                }

                if (wonBattle % 3 == 0)
                {
                    firstEnergy += wonBattle;
                }
                    

                comand = Console.ReadLine();
            }

            if (doNotEnergy == false)
            {
                Console.WriteLine($"Won battles: {wonBattle}. Energy left: {firstEnergy}");
            }
        }
    }
}
