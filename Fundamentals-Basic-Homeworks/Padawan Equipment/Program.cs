using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountMoney = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            double moneyLightsabers = (countStudents + Math.Ceiling(countStudents * 0.1)) * priceLightsabers;
            double moneyRobes = countStudents * priceRobes;
            double moneyBelts = (countStudents - (countStudents / 6)) * priceBelts;

            double amountEquipment = moneyLightsabers + moneyRobes + moneyBelts;

            double diff = amountMoney - amountEquipment;

            if (amountMoney >= amountEquipment)
            {
                Console.WriteLine($"The money is enough - it would cost {amountEquipment:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(diff):f2}lv more.");
            }

        }
    }
}
