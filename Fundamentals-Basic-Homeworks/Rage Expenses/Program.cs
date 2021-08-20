using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashHeadset = lostGamesCount / 2;
            int trashMouse = lostGamesCount / 3;
            int trashKeyboard = lostGamesCount / 6;
            int trashDisplay = lostGamesCount / 12;

            double amountHeadset = trashHeadset * headsetPrice;
            double amountMouse = trashMouse * mousePrice;
            double amountKeyboard = trashKeyboard * keyboardPrice;
            double amountDisplay = trashDisplay * displayPrice;

            double totalAmount = amountHeadset + amountMouse + amountKeyboard + amountDisplay;

            Console.WriteLine($"Rage expenses: {totalAmount:f2} lv.");
        }
    }
}
