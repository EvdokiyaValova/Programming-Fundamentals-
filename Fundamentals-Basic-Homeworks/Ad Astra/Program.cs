using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

 //           string pattern = @"(\||#)([A-Za-z]+)\1([0-9]{2}\/[0-9]{2}\/[0-9]{2})\1([0-9]+)\1";

            Regex regex = new Regex(@"(\||#)([A-Za-z ]+)\1([0-9]{2}\/[0-9]{2}\/[0-9]{2})\1([0-9]{1,5})\1");

            MatchCollection matches = regex.Matches(input);

            int sumCalories = 0;            

            foreach (Match match in matches)
            {
                int calories = (int.Parse)(match.Groups[4].Value);
                sumCalories += calories;
            }

            int days = sumCalories / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups[2].Value}, Best before: {match.Groups[3].Value}, Nutrition: {match.Groups[4].Value}");
            }
        }
    }
}
