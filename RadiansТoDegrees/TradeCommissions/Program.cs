using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0;
            bool flag = true;

            if (sales >= 0 && sales <= 500)
            {
                switch (town)
                {
                    case "Sofia":
                        commission = sales * 0.05;
                        break;
                    case "Varna":
                        commission = sales * 0.045;
                        break;
                    case "Plovdiv":
                        commission = sales * 0.055;
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
            else if (sales > 500 && sales <= 1000)
            {
                switch (town)
                {
                    case "Sofia":
                        commission = sales * 0.07;
                        break;
                    case "Varna":
                        commission = sales * 0.075;
                        break;
                    case "Plovdiv":
                        commission = sales * 0.08;
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
            else if (sales > 1000 && sales <= 10000)
            {
                switch (town)
                {
                    case "Sofia":
                        commission = sales * 0.08;
                        break;
                    case "Varna":
                        commission = sales * 0.10;
                        break;
                    case "Plovdiv":
                        commission = sales * 0.12;
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
            else if (sales > 10000)
            {
                switch (town)
                {
                    case "Sofia":
                        commission = sales * 0.12;
                        break;
                    case "Varna":
                        commission = sales * 0.13;
                        break;
                    case "Plovdiv":
                        commission = sales * 0.145;
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
            else 
            {
                flag = false;
            }
            if (flag)
            {
                Console.WriteLine("{0:f2}", commission);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
