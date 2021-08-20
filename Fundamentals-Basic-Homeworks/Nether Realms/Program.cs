using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            Dictionary<string, double> namesHealt = new Dictionary<string, double>();
            Dictionary<string, double> namesDamage = new Dictionary<string, double>();
            string nameDemon = string.Empty;
            int demonHealth = 0;
            double demonDamage = 0;

            for (int i = 0; i < input.Length; i++)
            {
                nameDemon += input[i];
                namesHealt.Add(nameDemon, 0);
                namesDamage.Add(nameDemon, 0);
                string currentDamon = input[i];
                for (int j = 0; j < currentDamon.Length; j++)
                {
                    if (currentDamon[j] == '+' || currentDamon[j] == '-' || currentDamon[j] == '/'
                        || currentDamon[j] == '*' || currentDamon[j] == '.' 
                        || (currentDamon[j] >= 48 && currentDamon[j] <= 57))
                    {
                        continue;
                    }
                    else
                    {
                        
                        demonHealth += currentDamon[j];
                    }
                }

                namesHealt[nameDemon] += demonHealth;

                string pattern = @"([\+|\-]?[\d]+[\.]?[\d]*)(\/*\**)";
                Regex regex = new Regex(@"([\+|\-]?[\d]+[\.]?[\d]*)(\/*\**)");
                MatchCollection matches = regex.Matches(nameDemon);

                double damageSum = 0;
                string simbol = string.Empty;

                foreach (Match match in matches)
                {
                    damageSum += double.Parse(match.Groups[1].Value);
                    simbol += match.Groups[2].Value;
                }

                for (int k = 0; k < simbol.Length; k++)
                {
                    if (simbol[k] == '*')
                    {
                        damageSum *= 2;
                    }
                    else if (simbol[k] == '/')
                    {
                        damageSum /= 2;
                    }
                }

                namesDamage[nameDemon] += damageSum;
            }

            namesHealt = namesHealt.OrderBy(d => d).ToDictionary(d => d.Key, d => d.Value);

            // •	"{demon name} - {health points} health, {damage points} damage"

            foreach (var item in namesHealt)
            {
                Console.WriteLine($"{item.Key} - {item.Value} health, {namesDamage[item.Key]:f2} damage");
            }
        }
    }
}
