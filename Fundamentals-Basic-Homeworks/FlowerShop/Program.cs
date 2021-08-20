using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnoliasCount = int.Parse(Console.ReadLine());
            int hyacinthsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int cactiCount = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double magnoliasPrice = magnoliasCount * 3.25;
            double hyacinthsPrice = hyacinthsCount * 4;
            double rosesPrice = rosesCount * 3.50;
            double cactiPrice = cactiCount * 8;

            double flowerPrice = magnoliasPrice + hyacinthsPrice + rosesPrice + cactiPrice;
            double money = flowerPrice * 0.95;

            double difference = Math.Abs(giftPrice - money);

            if (giftPrice <= money)
            {
                Console.WriteLine($"She is left with {Math.Floor(difference):f0} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(difference):f0} leva.");
            }
        }
    }
}
