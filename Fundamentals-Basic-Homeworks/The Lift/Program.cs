using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            List<int> lift = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            int emptySpaces;
            int uploadedPeople = 0;

            for (int i = 0; i < lift.Count; i++)
            {
                if (lift[i] < 4)
                {
                    emptySpaces = 4 - lift[i];

                    if (countPeople > 0)
                    {
                        
                        if (countPeople >= emptySpaces)
                        {                            
                            lift[i] = lift[i] + emptySpaces;
                            countPeople -= emptySpaces;
                        }
                        else if (countPeople > 0 && countPeople < emptySpaces)
                        {                            
                            lift[i] = lift[i] + countPeople;
                            countPeople -= countPeople;
                        }
                        
                    }
                    else
                    {
                        continue;
                    }
                }
                uploadedPeople += lift[i];              
                
            }

            int capacity = lift.Count * 4;

            if (capacity > uploadedPeople)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (capacity == uploadedPeople && countPeople == 0)
            {
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (countPeople > 0)
            {
                Console.WriteLine($"There isn't enough space! {countPeople} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
        }
    }
}
