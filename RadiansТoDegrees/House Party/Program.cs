using System;
using System.Collections.Generic;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberComand = int.Parse(Console.ReadLine());
            List<string> allTheGuests = new List<string>();
            

            for (int i = 0; i < numberComand; i++)
            {
                string[] comands = Console.ReadLine().Split();
                string comand = comands[2];
                string name = comands[0];

                if (comand == "going!")
                {
                    bool isHave = false;
                    for (int j = 0; j < allTheGuests.Count; j++)
                    {
                        if (allTheGuests [j] == name)
                        {
                            isHave = true;
                            break;
                        }
                        else
                        {
                            isHave = false;
                        }                        
                    }

                    if (isHave)
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        allTheGuests.Add(name);     
                    }
                }
                else if (comand == "not")
                {
                    bool isHave = false;
                    for (int j = 0; j < allTheGuests.Count; j++)
                    {
                        if (allTheGuests[j] == name)
                        {
                            isHave = true;
                            break;
                        }
                        else
                        {
                            isHave = false;
                        }
                    }

                    if (!isHave)
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else
                    {
                        allTheGuests.RemoveAll(x => x== name);
                    }
                }              
            }

            for (int i = 0; i < allTheGuests.Count; i++)
            {
                Console.WriteLine(allTheGuests[i]);
            } 
        }
    }
}
