using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split("!").ToList();

            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] comand = input.Split().ToArray();

                Urgent(shoppingList, comand);

                Unnecessary(shoppingList, comand);

                Correct(shoppingList, comand);

                Rearrange(shoppingList, comand);

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }

        private static void Rearrange(List<string> shoppingList, string[] comand)
        {
            if (comand[0] == "Rearrange")
            {
                int count = 0;
                int index = 0;
                for (int i = 0; i < shoppingList.Count; i++)
                {
                    if (comand[1] == shoppingList[i])
                    {
                        count++;
                        index = i;
                    }
                }

                if (count > 0)
                {
                    string temp = shoppingList[index];
                    shoppingList.RemoveAt(index);
                    shoppingList.Add(temp);
                }
            }
        }

        private static void Correct(List<string> shoppingList, string[] comand)
        {
            if (comand[0] == "Correct")
            {
                int count = 0;
                int index = 0;
                for (int i = 0; i < shoppingList.Count; i++)
                {
                    if (comand[1] == shoppingList[i])
                    {
                        count++;
                        index = i;
                    }
                }

                if (count > 0)
                {
                    shoppingList[index] = comand[2];
                }
            }
        }

        private static void Unnecessary(List<string> shoppingList, string[] comand)
        {
            if (comand[0] == "Unnecessary")
            {
                int count = 0;
                int index = 0;
                for (int i = 0; i < shoppingList.Count; i++)
                {
                    if (comand[1] == shoppingList[i])
                    {
                        count++;
                        index = i;
                    }
                }

                if (count > 0)
                {
                    shoppingList.RemoveAt(index);
                }
            }
        }

        private static void Urgent(List<string> shoppingList, string[] comand)
        {
            if (comand[0] == "Urgent")
            {
                int count = 0;
                for (int i = 0; i < shoppingList.Count; i++)
                {
                    if (comand[1] == shoppingList[i])
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                    shoppingList.Insert(0, comand[1]);
                }
            }
        }
    }
}
