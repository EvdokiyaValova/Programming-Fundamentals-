using System;
using System.Collections.Generic;
using System.Linq;

namespace Man_O_War2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warship = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maximumHealthCapacity = int.Parse(Console.ReadLine());

            List<string> comand = Console.ReadLine().Split().ToList();
            bool piratesAreDead = false;
            bool wariorsAreDead = false;

            while (comand[0] != "Retire")
            {
                if (comand[0] == "Fire")
                {
                    int indexAttack = int.Parse(comand[1]);
                    int damage = int.Parse(comand[2]);

                    if (indexAttack >= 0 && indexAttack < warship.Count)
                    {
                       int isShot = warship[indexAttack] - damage;

                        if (isShot <= 0)
                        {
                            wariorsAreDead = true;
                            Console.WriteLine("You won! The enemy ship has sunken.");                            
                        }
                        else
                        {
                            warship.RemoveAt(indexAttack);
                            warship.Insert(indexAttack, isShot);                            
                        }
                    }
                    if (wariorsAreDead == true)
                    {
                        break;
                    }  
                }
                else if (comand[0] == "Defend")
                {
                    int startIndexAttack = int.Parse(comand[1]);
                    int endIndexAttack = int.Parse(comand[2]);
                    int damage = int.Parse(comand[3]);
                    int startIndex = Math.Min(startIndexAttack, endIndexAttack);
                    int endIndex = Math.Max(startIndexAttack, endIndexAttack);

                    if (startIndex >= 0 && endIndex < pirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                           int isShotesPirates =  pirateShip[i] - damage;

                            if (isShotesPirates <= 0)
                            {
                                piratesAreDead = true;

                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                break;
                            }
                            else
                            {
                                pirateShip.RemoveAt(i);
                                pirateShip.Insert(i, isShotesPirates);
                                startIndex++;
                                
                            }
                        }
                        if (piratesAreDead == true)
                        {
                            break;
                        }
                    }

                }
                else if (comand[0] == "Repair")
                {
                    int indexRepair = int.Parse(comand[1]);
                    int health = int.Parse(comand[2]);

                    if (indexRepair >= 0 && indexRepair < pirateShip.Count)
                    {
                        int isRepaired = pirateShip[indexRepair] + health;

                        if (isRepaired >= maximumHealthCapacity)
                        {
                            isRepaired = maximumHealthCapacity;
                            pirateShip.RemoveAt(indexRepair);
                            pirateShip.Insert(indexRepair, isRepaired);                            
                        }
                        else
                        {                           
                            pirateShip.RemoveAt(indexRepair);
                            pirateShip.Insert(indexRepair, isRepaired);                            
                        }
                    }
                }
                else if (comand[0] == "Status")
                {                                     
                    int countSectionRepair = 0;
                    double healthSection = maximumHealthCapacity * 0.2;
                    for (int i = 0; i < pirateShip.Count; i++)
                    {             
                        if (pirateShip[i] < healthSection)
                        {
                            countSectionRepair++;
                        }
                    }

                    Console.WriteLine($"{countSectionRepair} sections need repair.");                    
                }

                comand = Console.ReadLine().Split().ToList();
            }

            if (piratesAreDead == false && wariorsAreDead == false)
            {
                int pirateShipSum = 0;
                for (int i = 0; i < pirateShip.Count; i++)
                {
                    pirateShipSum += pirateShip[i];
                }

                int warshipSum = 0;
                for (int i = 0; i < warship.Count; i++)
                {
                    warshipSum += warship[i];
                }

                Console.WriteLine($"Pirate ship status: {pirateShipSum}");
                Console.WriteLine($"Warship status: {warshipSum}");
            }  
        }
    }
}

    

