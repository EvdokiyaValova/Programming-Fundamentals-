using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());

            int puzzlesNumbers = int.Parse(Console.ReadLine());
            int dollsNumbers = int.Parse(Console.ReadLine());
            int bearsNumbers = int.Parse(Console.ReadLine());
            int minionsNumbers = int.Parse(Console.ReadLine());
            int trucksNumbers = int.Parse(Console.ReadLine());

            double puzzlesPrice = puzzlesNumbers * 2.60;
            double dollsPrice = dollsNumbers * 3;
            double bearsPrice = bearsNumbers * 4.10;
            double minionsPrice = minionsNumbers * 8.20;
            double trucksPrice = trucksNumbers * 2;

            double toysPrice = puzzlesPrice + dollsPrice + bearsPrice + minionsPrice + trucksPrice;

            int numbersToys = puzzlesNumbers + dollsNumbers + bearsNumbers + minionsNumbers + trucksNumbers;

            if (numbersToys >= 50)
            {
                toysPrice = toysPrice * 0.75;

            }

            double rent = toysPrice * 0.10;
            double total = toysPrice - rent;

            if (excursionPrice <= total)
            {
                Console.WriteLine($"Yes! {(total - excursionPrice):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(excursionPrice - total):f2} lv needed.");
            }
        }
    }
}
