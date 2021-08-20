using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string[] comand = Console.ReadLine()
                .Split();
            while (comand [0] != "End")
            {                
                if (comand[0] == "Add")
                {
                    int element = int.Parse(comand[1]);
                    numbers.Add(element);
                }
                else if (comand[0] == "Insert")
                {                    
                    int element = int.Parse(comand[1]);
                    int index = int.Parse(comand[2]);
                    
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, element);
                    }
                }
                else if (comand[0] == "Remove")
                {
                    int index = int.Parse(comand[1]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (comand[0] == "Shift")
                {
                    if (comand[1] == "left")
                    {
                        
                        int count = int.Parse(comand[2]);

                        for (int i = 0; i < count; i++)
                        {
                            int element = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(element);
                        }
                    }
                    else if (comand[1] == "right")
                    {
                        
                        int count = int.Parse(comand[2]);

                        for (int i = 0; i < count; i++)
                        {
                            int element = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count -1);
                            numbers.Insert(0, element);
                        }
                    }
                }
                comand = Console.ReadLine()
                .Split();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
