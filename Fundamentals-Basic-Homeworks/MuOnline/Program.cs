using System;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] roomsArray = Console.ReadLine().Split("|");

            int health = 100;
            bool died = false;
            int bestRoom = 0;
            int bitcoins = 0;

            for (int i = 0; i < roomsArray.Length; i++)
            {
                string[] currentRoom = roomsArray[i].Split();
                bestRoom++;                
                
                if (currentRoom[0] == "potion")
                {
                    int potion = int.Parse(currentRoom[1]);                    
                   
                    
                    if (health + potion >= 100)
                    {
                        int diff = 100 - health;
                        health = 100;
                        potion = diff;
                    }
                    else
                    {
                        health += potion;
                    }
                    
                    Console.WriteLine($"You healed for {potion} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
;                }
                else if (currentRoom[0] == "chest")
                {
                    int chest = int.Parse(currentRoom[1]);
                    bitcoins += chest;
                    Console.WriteLine($"You found {chest} bitcoins.");

                }
                else
                {
                    string monster = currentRoom[0];
                    int powerMonster = int.Parse(currentRoom[1]);
                    health -= powerMonster;
                    if (health <=0)
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        died = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                }
                
            }

            if (died == false)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}




