using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberKegs = int.Parse(Console.ReadLine());

            double maxVolume = 0;
            string biggestKeg = "";

            for (int i = 0; i < numberKegs; i++)
            {
                string modelKeg = Console.ReadLine();
                double radiusKeg = double.Parse(Console.ReadLine());
                int heightKeg = int.Parse(Console.ReadLine());

                double volume = Math.PI * radiusKeg * radiusKeg * heightKeg;

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    biggestKeg = modelKeg;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
