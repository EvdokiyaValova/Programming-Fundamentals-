using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string[] comand = Console.ReadLine()
                .Split();
            while (comand[0] != "end")
            {
                if (comand[0] == "Delete")
                {
                    int elementForDelete = int.Parse(comand[1]);

                    listOfIntegers.RemoveAll(x => x == elementForDelete);
                }
                else if (comand[0] == "Insert")
                {
                    int elements = int.Parse(comand[1]);
                    int index = int.Parse(comand[2]);

                    listOfIntegers.Insert(index, elements);
                }

                comand = Console.ReadLine()
                .Split();
            }

            Console.WriteLine(string.Join(" ", listOfIntegers));
        }
    }
}
