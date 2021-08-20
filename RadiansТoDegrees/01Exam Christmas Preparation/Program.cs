using System;

namespace _01Exam_Christmas_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRollsPaper = int.Parse(Console.ReadLine());
            int numberRollsFabric = int.Parse(Console.ReadLine());
            double litersGlue = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double pricePaper = numberRollsPaper * 5.80;
            double priceFabric = numberRollsFabric * 7.20;
            double priceGlue = litersGlue * 1.20;

            double sumPrice = pricePaper + priceFabric + priceGlue;
            double totalPrice = sumPrice - (sumPrice * discount / 100);

            Console.WriteLine($"{totalPrice:f3}");
        }
    }
}
