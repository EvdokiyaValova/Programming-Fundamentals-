using System;

namespace Vacntions2
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double raisedMoney = double.Parse(Console.ReadLine());

            int countDays = 0;
            int spendDays = 0;
            bool flag = true;

            while (raisedMoney < moneyNeeded && spendDays < 5)
            {
                string typeAction = Console.ReadLine();
                double amountMoney = double.Parse(Console.ReadLine());

                countDays++;

                if (typeAction == "spend")
                {                    
                    spendDays++; 
                    flag = false;
                    raisedMoney -= amountMoney;

                    if (raisedMoney < 0)
                    {
                        raisedMoney = 0;
                    }
                }
                else if (typeAction == "save")
                {
                    flag = true;
                    spendDays = 0;
                    raisedMoney += amountMoney;
                }
            }

            if (raisedMoney >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {countDays} days.");
               
            }

            if (spendDays == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(countDays);
               
            }

        }
    }
}
