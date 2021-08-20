using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> comand = Console.ReadLine().Split().ToList();

            while (comand[0] != "Finish")
            {
                if (comand[0] == "Add")
                {
                    int value = int.Parse(comand[1]);
                    elements.Add(value);
                }
                else if (comand[0] == "Remove")
                {
                    int value = int.Parse(comand[1]);
                    for (int i = 0; i < elements.Count; i++)
                    {
                        if (elements[i] == value)
                        {
                            elements.RemoveAt(i);
                            break;
                        }
                    }
                }
                else if (comand[0] == "Replace")
                {
                    int value = int.Parse(comand[1]);
                    int replacment = int.Parse(comand[2]);

                    for (int i = 0; i < elements.Count; i++)
                    {
                        if (elements[i] == value)
                        {
                            elements.RemoveAt(i);
                            elements.Insert(i, replacment);
                            break;
                        }
                    }

                }
                else if (comand[0] == "Collapse")
                {
                    int value = int.Parse(comand[1]);

                    for (int i = 0; i < elements.Count; i++)
                    {
                        if (elements[i] < value)
                        {
                            elements[i] = 1001;
                        }
                    }

                    elements.RemoveAll(x => x==1001);
                }
                comand = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
