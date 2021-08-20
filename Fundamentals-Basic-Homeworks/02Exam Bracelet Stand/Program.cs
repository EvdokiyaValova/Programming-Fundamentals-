using System;

namespace _02Exam_Bracelet_Stand
{
    class Program
    {
        static void Main(string[] args)
        {
            double pocketsMoneyPerDay = double.Parse(Console.ReadLine());
            double earnedMoneyPerDay = double.Parse(Console.ReadLine());
            double expensesWholePeriod = double.Parse(Console.ReadLine());
            double priceGift = double.Parse(Console.ReadLine());

            double pocketsMoney = 5 * pocketsMoneyPerDay;
            double earnedMoney = 5 * earnedMoneyPerDay;
            double moneySaved = pocketsMoney + earnedMoney;
            double totalMomeySeved = moneySaved - expensesWholePeriod;

            if (totalMomeySeved >= priceGift)
            {
                Console.WriteLine($"Profit: {totalMomeySeved:f2} BGN, the gift has been purchased.");
            }
            else
            {
                double diff = priceGift - totalMomeySeved;

                Console.WriteLine($"Insufficient money: {diff:f2} BGN.");
            }

        }
    }
}
