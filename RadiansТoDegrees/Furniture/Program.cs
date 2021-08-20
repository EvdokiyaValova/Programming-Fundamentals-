using System;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^>>([A-za-z]+)<<(\d+\.*\d+)!(\d+)$";
            Regex regex = new Regex(@"^>>([A-za-z]+)<<(\d+\.?\d*)!(\d+)");

            double totalSum = 0;

            Console.WriteLine("Bought furniture:");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Purchase")
                {
                    break;
                }

                
                Match match = regex.Match(input);

                if (!match.Success)
                {
                    continue;
                }

                double price = double.Parse(match.Groups[2].Value);
                int quantity = int.Parse(match.Groups[3].Value);

                double sum = price * quantity;
                totalSum += sum;

                Console.WriteLine(match.Groups[1]);
            }

            Console.WriteLine($"Total money spend: {totalSum:f2}");
        }
    }
}
