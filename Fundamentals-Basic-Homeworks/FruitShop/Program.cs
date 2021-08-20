using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price;
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            price = quantity * 2.5;
                            Console.WriteLine("{0:f2}", price);
                            break;
                        case "apple":
                            price = quantity * 1.20;
                            Console.WriteLine("{0:f2}", price);
                            break;
                        case "orange":
                            price = quantity * 0.85;
                            Console.WriteLine("{0:f2}", price);
                            break;
                        case "grapefruit":
                            price = quantity * 1.45;
                            Console.WriteLine("{0:f2}", price);
                            break;
                        case "kiwi":
                            price = quantity * 2.70;
                            Console.WriteLine("{0:f2}", price);
                            break;
                        case "pineapple":
                            price = quantity * 5.50;
                            Console.WriteLine("{0:f2}", price);
                            break;
                        case "grapes":
                            price = quantity * 3.85;
                            Console.WriteLine("{0:f2}", price);
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            price = quantity * 2.70;
                            Console.WriteLine("{0:f2}", price);
                            break;
                        case "apple":
                            price = quantity * 1.25;
                            Console.WriteLine("{0:f2}", price);
                            break;
                        case "orange":
                            price = quantity * 0.90;
                            Console.WriteLine("{0:f2}", price);
                            break;
                        case "grapefruit":
                            price = quantity * 1.60;
                            Console.WriteLine("{0:f2}", price);
                            break;
                        case "kiwi":
                            price = quantity * 3.00;
                            Console.WriteLine("{0:f2}", price);
                            break;
                        case "pineapple":
                            price = quantity * 5.60;
                            Console.WriteLine("{0:f2}", price);
                            break;
                        case "grapes":
                            price = quantity * 4.20;
                            Console.WriteLine("{0:f2}", price);
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }          
        }
    }
}
