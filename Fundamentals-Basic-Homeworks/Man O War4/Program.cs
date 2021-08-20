using System;
using System.Collections.Generic;
using System.Linq;

namespace Man_O_War3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> piratesShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warship = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealth = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();

            bool isDead = false;

            while (comand != "Retire")
            {
                List<string> currentComand = comand.Split().ToList();


                if (currentComand[0] == "Fire")
                {
                    int indexFire = int.Parse(currentComand[1]);
                    int damageFire = int.Parse(currentComand[2]);

                    if (indexFire >= 0 && indexFire < warship.Count)
                    {
                        int fireResult = warship[indexFire] - damageFire;

                        if (fireResult <= 0)
                        {
                            isDead = true;
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            break;
                        }
                        else
                        {
                            warship[indexFire] = fireResult;
                        }
                    }
                    if (isDead)
                    {
                        break;
                    }
                }
                else if (currentComand[0] == "Defend")
                {
                    int startIndex = int.Parse(currentComand[1]);
                    int endIndex = int.Parse(currentComand[2]);
                    int damageDefend = int.Parse(currentComand[3]);

                    if (startIndex >= 0 && endIndex < piratesShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            int defendedResul = piratesShip[i] - damageDefend;

                            if (defendedResul <= 0)
                            {
                                isDead = true;

                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                break;
                            }
                            else
                            {
                                piratesShip[i] = defendedResul;
                            }
                        }                        
                    }
                    if (isDead)
                    {
                        break;
                    }
                }
                else if (currentComand[0] == "Repair")
                {
                    int indexRepair = int.Parse(currentComand[1]);
                    int health = int.Parse(currentComand[2]);

                    if (indexRepair >= 0 && indexRepair < piratesShip.Count)
                    {
                        int resultRepair = piratesShip[indexRepair] + health;

                        if (resultRepair >= maxHealth)
                        {
                            resultRepair = maxHealth;
                            piratesShip[indexRepair] = resultRepair;
                        }
                        else
                        {
                            piratesShip[indexRepair] = resultRepair;
                        }
                    }
                }
                else if (currentComand[0] == "Status")
                {
                    int countLower = 0;

                    for (int i = 0; i < piratesShip.Count; i++)
                    {
                        if (piratesShip[i] < maxHealth * 0.2)
                        {
                            countLower++;
                        }
                    }

                    Console.WriteLine($"{countLower} sections need repair.");
                }

                comand = Console.ReadLine();
            }

            if (!isDead)
            {
                int sumPirates = 0;

                for (int i = 0; i < piratesShip.Count; i++)
                {
                    sumPirates += piratesShip[i];
                }

                int sumWarship = 0;

                for (int i = 0; i < warship.Count; i++)
                {
                    sumWarship += warship[i];
                }

                Console.WriteLine($"Pirate ship status: {sumPirates}");
                Console.WriteLine($"Warship status: {sumWarship}");
            }

        }
    }
}
