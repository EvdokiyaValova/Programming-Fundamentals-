using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            double priceToys = double.Parse(Console.ReadLine());

            int numberToys = 0;
            int numberMoney = 0;
            int sumMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 1)
                {
                    numberToys ++;
                }
                else
                {
                    numberMoney ++;
                    sumMoney += i/2 * 10;
                }
            }

            double moneyToys = numberToys * priceToys;
            int moneyBirthday = sumMoney - numberMoney;
            double totalMoney = moneyToys + moneyBirthday;
            double diff = Math.Abs(totalMoney - priceWashingMachine);

            if (totalMoney >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}
