using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Users2
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> register = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string[] currentData = Console.ReadLine().Split(" -> ").ToArray();

                if (currentData[0] == "End")
                {
                    break;
                }

                string company = currentData[0];
                string employeeID= currentData[1];

                if (!register.ContainsKey(company))
                {
                    register.Add(company, new List<string>());
                }

                    register[company].Add(employeeID);              
            }

            foreach (var kvp in register)
            {
                Console.WriteLine(kvp.Key);

                List<string> uniqueID = kvp.Value
                    .Distinct()
                    .ToList();

                foreach (var employes in uniqueID)
                {
                    Console.WriteLine($"-- {employes}");
                }
            }
        }
    }
}
