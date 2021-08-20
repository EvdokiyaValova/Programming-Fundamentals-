using System;
using System.Text.RegularExpressions;

namespace Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

         //   string pattern = @"^@#+([A-Z][a-zA-Z0-9]{5,})@#+$";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(@"^@#+(?=[A-Z])(?<barcode>[A-Za-z0-9]{6,})(?<=[A-Z])@#+$");

                Match match = regex.Match(input);

                bool containsValid = regex.IsMatch(input);

                if (containsValid)
                {
                    Regex regexDigit = new Regex(@"([0-9])");
                    MatchCollection matches1 = regexDigit.Matches(input);
                    string digit = string.Empty;

                    foreach (Match match1 in matches1)
                    {
                        digit += match1.Groups[1].Value;
                    }

                    if (digit == string.Empty)
                    {
                        digit = "00";
                    }

                    Console.WriteLine($"Product group: {digit}");

                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }


            }
        }
    }
}
