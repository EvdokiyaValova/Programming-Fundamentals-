using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                List<string> comand = input.Split(" - ").ToList();

                if (comand[0] == "Collect")
                {
                    bool itIs = false;
                    for (int i = 0; i < elements.Count; i++)
                    {

                        if (comand[1] == elements[i])
                        {
                            itIs = true;
                        }                        
                    }

                    if (itIs == false)
                    {
                        elements.Add(comand[1]);
                    }
                }
                else if (comand[0] == "Drop")
                {
                    bool itIs = false;
                    int index = 0;
                    for (int i = 0; i < elements.Count; i++)
                    {
                        if (comand[1] == elements[i]) 
                        {
                            itIs = true;
                            index = i;
                        }
                    }

                    if (itIs == true)
                    {
                        elements.RemoveAt(index);
                    }
                }
                else if (comand[0] == "Combine Items")
                {
                    List<string> currentComand = comand[1].Split(":").ToList();
                    bool itIs = false;
                    int index = 0;
                    for (int i = 0; i < elements.Count; i++)
                    {
                        if (currentComand[0] == elements[i])
                        {
                            itIs = true;
                            index = i;
                        }
                    }

                    if (itIs == true)
                    {
                        elements.Insert(index + 1, currentComand[1]);
                    }
                }
                else if (comand[0] == "Renew")
                {
                    bool itIs = false;
                    int index = 0;
                    for (int i = 0; i < elements.Count; i++)
                    {
                        if (comand[1] == elements[i])
                        {
                            itIs = true;
                            index = i;
                        }
                    }

                    if (itIs == true)
                    {
                        elements.RemoveAt(index);
                        elements.Add(comand[1]);
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", elements));
        }
    }
}
