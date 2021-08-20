using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSnowballs = int.Parse(Console.ReadLine());

            BigInteger maxSnowballValue = 0;
            //            int maxsnowballSnow = 0;
            //            int maxsnowballTime = 0;
            //            int maxsnowballQuality = 0;
            string result = string.Empty;

            for (int i = 0; i < numberSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballValue >= maxSnowballValue)
                {
                    maxSnowballValue = snowballValue;
                    //                    maxsnowballSnow = snowballSnow;
                    //                    maxsnowballTime = snowballTime;
                    //                    maxsnowballQuality = snowballQuality;
                    result = $"{snowballSnow } : {snowballTime} = {maxSnowballValue} ({snowballQuality})";
                }

            }

            Console.WriteLine(result);
        }
    }
}
