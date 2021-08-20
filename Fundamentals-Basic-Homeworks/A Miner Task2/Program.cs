using System;
using System.Collections.Generic;

namespace A_Miner_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resurs = new Dictionary<string, int>();
            int count = 0;
            string currentKey = "";

            while (true)
            {
                string currentResurs = Console.ReadLine();
                count++;

                if (currentResurs == "stop")
                {
                    break;
                }
                else if (count %2 != 0)
                {
                    currentKey = currentResurs;
                    if (resurs.ContainsKey(currentKey) == false)
                    {
                        resurs.Add(currentKey, 0);
                    }
                   
                }
                else if (count % 2 == 0)
                {
                    int currentValue = int.Parse(currentResurs);
                    resurs[currentKey] += currentValue;                   
                }
            }

            foreach (var kvp in resurs)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
