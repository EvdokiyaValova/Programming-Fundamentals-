using System;
using System.Collections.Generic;
using System.Linq;

namespace Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> heroesHP = new Dictionary<string, int>();
            Dictionary<string, int> heroesMP = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] heroes = Console.ReadLine().Split();
                // {hero name} {HP} {MP} 

                if (!heroesHP.ContainsKey(heroes[0]))
                {
                    heroesHP.Add(heroes[0], int.Parse(heroes[1]));
                    heroesMP.Add(heroes[0], int.Parse(heroes[2]));
                }
            }

            while (true)
            {
                string currentComand = Console.ReadLine();

                if (currentComand == "End")
                {
                    break;
                }

                List<string> comand = currentComand.Split(" - ").ToList();

                if (comand[0] == "CastSpell")
                {
                    // CastSpell – {hero name} – {MP needed} – {spell name} 

                    string hero = comand[1];
                    int quantitySpell = int.Parse(comand[2]);
                    string spelName = comand[3];

                    if (heroesMP[hero] < quantitySpell)
                    {
                        Console.WriteLine($"{hero} does not have enough MP to cast {spelName}!");
                    }
                    else
                    {
                        heroesMP[hero] -= quantitySpell;

                        Console.WriteLine($"{hero} has successfully cast {spelName} and now has {heroesMP[hero]} MP!");
                    }
                }
                else if (comand[0] == "TakeDamage")
                {
                    // TakeDamage – {hero name} – {damage} – {attacker}

                    string hero = comand[1];
                    int damage = int.Parse(comand[2]);
                    string attacker = comand[3];

                    if (heroesHP[hero] > damage)
                    {
                        heroesHP[hero] -= damage;

                        Console.WriteLine($"{hero} was hit for {damage} HP by {attacker} and now has {heroesHP[hero]} HP left!");
                    }
                    else
                    {
                        heroesHP.Remove(hero);
                        heroesMP.Remove(hero);

                        Console.WriteLine($"{hero} has been killed by {attacker}!");
                    }
                }
                else if (comand[0] == "Recharge")
                {
                    //Recharge – {hero name} – {amount}

                    string hero = comand[1];
                    int amount = int.Parse(comand[2]);

                    if (heroesMP[hero] + amount > 200)
                    {                        
                        amount = 200 - heroesMP[hero];
                        heroesMP[hero] = 200;
                    }
                    else
                    {
                        heroesMP[hero] += amount;
                    }

                    Console.WriteLine($"{hero} recharged for {amount} MP!");
                }
                else if (comand[0] == "Heal")
                {
                    // Heal – {hero name} – {amount}

                    string hero = comand[1];
                    int amount = int.Parse(comand[2]);

                    if (heroesHP[hero] + amount > 100)
                    {
                        amount = 100 - heroesHP[hero];
                        heroesHP[hero] = 100;                        
                    }
                    else
                    {
                        heroesHP[hero] += amount;
                    }

                    Console.WriteLine($"{hero} healed for {amount} HP!");
                }
            }

            Dictionary<string, int> sortedHP = heroesHP
                .OrderByDescending(h => h.Value)
                .ThenBy(h => h.Key)
                .ToDictionary(h => h.Key, h => h.Value);

            foreach (var kvp in sortedHP)
            {
                // Solmyr
                // HP: 95
                // MP: 170

                Console.WriteLine(kvp.Key);
                Console.WriteLine($"HP: {kvp.Value}");
                Console.WriteLine($"MP: {heroesMP[kvp.Key]}");
            }
        }
    }
}
