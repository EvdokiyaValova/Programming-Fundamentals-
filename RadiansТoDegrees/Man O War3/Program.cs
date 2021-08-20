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
            List<string> comand = Console.ReadLine().Split().ToList(); 

            bool isDead = false;
            bool isDead2 = false;

            while (comand[0] != "Retire")           {              
               

                if (comand[0] == "Fire")
                {
                    int indexFire = int.Parse(comand[1]);
                    int damageFire = int.Parse(comand[2]);
                    
                    if (indexFire >= 0 && indexFire < warship.Count)
                    {
                        int fireResult = warship[indexFire] - damageFire;

                        if (fireResult <= 0)
                        {
                            isDead = true;
                            Console.WriteLine("You won! The enemy ship has sunken.");
                        }
                        else 
                        {
                            warship.RemoveAt(indexFire);
                            warship.Insert(indexFire, fireResult);
                        }
                    }
                    if (isDead == true)
                    {
                        break;
                    }
                }
                else if (comand[0] == "Defend")
                {
                    int startIndex = int.Parse(comand[1]);
                    int endIndex = int.Parse(comand[2]);
                    int damageDefend = int.Parse(comand[3]);

                    int firstIndex = Math.Min(startIndex, endIndex);
                    int seconIndex = Math.Max(startIndex, endIndex);

                    if (firstIndex >= 0 && firstIndex < piratesShip.Count && seconIndex >= 0 && seconIndex < piratesShip.Count)
                    {                        
                        for (int i = firstIndex; i <= seconIndex; i++)
                        {
                            int defendedResul = piratesShip[i] - damageDefend;                            

                            if (defendedResul <= 0)
                            {
                                isDead2 = true;

                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                break;
                            }
                            else
                            {
                                piratesShip.RemoveAt(i);
                                piratesShip.Insert(i, defendedResul);
                                firstIndex++;
                            }
                        }                        
                    }

                    if (isDead2 == true)
                    {
                        break;
                    }
                }
                else if(comand[0] == "Repair")
                {
                    int indexRepair = int.Parse(comand[1]);
                    int health = int.Parse(comand[2]);

                    if (indexRepair >= 0 && indexRepair < piratesShip.Count)
                    {
                        int resultRepair = piratesShip[indexRepair] + health;

                        if (resultRepair >= maxHealth)
                        {
                            resultRepair = maxHealth;
                            piratesShip.RemoveAt(indexRepair);
                            piratesShip.Insert(indexRepair, resultRepair);
                        }
                        else
                        {
                            piratesShip.RemoveAt(indexRepair);
                            piratesShip.Insert(indexRepair, resultRepair);
                        }
                    }
                }
                else if(comand[0] == "Status")
                {
                    int countLower = 0;
                    double forRepair = maxHealth * 0.2;

                    for (int i = 0; i < piratesShip.Count; i++)
                    {
                        if (piratesShip[i] < forRepair)
                        {
                            countLower ++;
                        }
                    }

                    Console.WriteLine($"{countLower} sections need repair.");
                }

                comand = Console.ReadLine().Split().ToList();
            }

            if (isDead == false && isDead2 == false)
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
