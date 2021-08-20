using System;
using System.Collections.Generic;

namespace SoftUni_Parking2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parkingValidation = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] currentUser = Console.ReadLine().Split();

                string username = currentUser[1];
                

                if (currentUser[0] == "register")
                {
                    string licensePlateNumber = currentUser[2];

                    if (!parkingValidation.ContainsKey(username))
                    {
                        parkingValidation.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else if (parkingValidation.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingValidation[username]}");
                    }
                    
                }
                else if (currentUser[0] == "unregister")
                {
                    if (!parkingValidation.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else if (parkingValidation.ContainsKey(username))
                    {
                        parkingValidation.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var kvp in parkingValidation)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
