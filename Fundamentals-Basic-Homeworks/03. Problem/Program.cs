using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine().Split(", ").ToList();
            List<string> comand = Console.ReadLine().Split(" - ").ToList();

            while (comand[0] != "End")
            {
                if (comand[0] == "Add")
                {
                    bool thereItIs = false;
                    string phone = comand[1];
                    for (int i = 0; i < phones.Count; i++)
                    {

                        if (phones[i] == phone)
                        {
                            thereItIs = true;
                        }
                    }

                    if (thereItIs == false)
                    {
                        phones.Add(phone);
                    }
                }
                else if (comand[0] == "Remove")
                {
                    bool thereItIs = false;
                    string phone = comand[1];

                    for (int i = 0; i < phones.Count; i++)
                    {
                        if (phones[i] == phone)
                        {
                            phones.RemoveAt(i);
                            break;
                        }
                    }

                }
                else if (comand[0] == "Bonus phone")
                {
                    bool thereItIs = false;
                    List <string> currentComand  = comand[1].Split(":").ToList();
                    string oldPhone = currentComand[0];
                    string newPhone = currentComand[1];

                    for (int i = 0; i < phones.Count; i++)
                    {
                        if (phones[i] == oldPhone)
                        {
                            phones.Insert(i + 1, newPhone);
                            break;
                        }
                    }
                }
                else if (comand[0] == "Last")
                {
                    bool thereItIs = false;
                    string phone = comand[1];

                    for (int i = 0; i < phones.Count; i++)
                    {
                        if (phones[i] == phone)
                        {
                            phones.RemoveAt(i);
                            phones.Add(phone);
                        }
                    }
                }
                comand = Console.ReadLine().Split(" - ").ToList();
            }

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
