using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine().Split(", ").ToList();
            string[] currentComand = Console.ReadLine().Split(" - ").ToArray();

            while (currentComand[0] != "Craft!")
            {
                //               string[] currentComand = comand.Split("-").ToArray();

                Collect(journal, currentComand);

                Drop(journal, currentComand);

                CombineItems(journal, currentComand);

                Renew(journal, currentComand);

                currentComand = Console.ReadLine().Split(" - ").ToArray();
            }
            Console.WriteLine(string.Join(", ", journal));
        }

        private static void Renew(List<string> journal, string[] currentComand)
        {
            if (currentComand[0] == "Renew")
            {
                int countComand = 0;
                int indexItem = 0;
                for (int i = 0; i < journal.Count; i++)
                {
                    if (currentComand[1] == journal[i])
                    {
                        countComand++;
                        indexItem = i;
                    }
                }

                if (countComand > 0)
                {
                    string temp = currentComand[1];
                    journal.RemoveAt(indexItem);
                    journal.Add(temp);
                }
            }
        }

        private static void CombineItems(List<string> journal, string[] currentComand)
        {
            if (currentComand[0] == "Combine Items")
            {
                string[] item = currentComand[1].Split(":").ToArray();
                int countComand = 0;
                int indexOldItem = 0;
                string newElement = item[1];
                for (int i = 0; i < journal.Count; i++)
                {
                    if (item[0] == journal[i])
                    {
                        countComand++;
                        indexOldItem = i;
                    }
                }

                if (countComand > 0)
                {
                    journal.Insert(indexOldItem + 1, item[1]);
                }
            }
        }

        private static void Drop(List<string> journal, string[] currentComand)
        {
            if (currentComand[0] == "Drop")
            {
                int countComand = 0;
                int indexComand = 0;
                for (int i = 0; i < journal.Count; i++)
                {
                    if (currentComand[1] == journal[i])
                    {
                        countComand++;
                        indexComand = i;
                    }
                }

                if (countComand > 0)
                {
                    journal.RemoveAt(indexComand);
                }
            }
        }

        private static void Collect(List<string> journal, string[] currentComand)
        {
            if (currentComand[0] == "Collect")
            {
                int countComand = 0;
                for (int i = 0; i < journal.Count; i++)
                {
                    if (currentComand[1] == journal[i])
                    {
                        countComand++;
                    }
                }

                if (countComand == 0)
                {
                    journal.Add(currentComand[1]);
                }
            }
        }
    }
}
