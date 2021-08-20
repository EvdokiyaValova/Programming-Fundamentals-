using System;
using System.Collections.Generic;
using System.Linq;

namespace Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split().ToList();
            string input = Console.ReadLine();
            bool win = false;
            int countGame = 0;

            while (input != "end")
            {
                int[] comand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int index1 = comand[0];
                int index2 = comand[1];                

                if (elements.Count == 0)
                {
                    win = true;
 //                   Console.WriteLine($"You have won in {countGame} turns!");
                    break;
                }
                else
                {
                    countGame++;
                    if (index1 == index2
                        || index1 < 0 || index1 >= elements.Count
                        || index2 < 0 || index2 >= elements.Count
                        || index1 == index2)
                    {
                        elements.Insert(elements.Count / 2, "-" + countGame + "a");
                        elements.Insert(elements.Count / 2, "-" + countGame + "a");

                        Console.WriteLine("Invalid input! Adding additional elements to the board");
                    }
                    else if (index1 >= 0 && index1 < elements.Count
                        && index2 >= 0 && index2 < elements.Count)
                    {
                        if (elements[index1] == elements[index2])
                        {
                            Console.WriteLine($"Congrats! You have found matching elements - {elements[index1]}!");
                            if (index1 > index2)
                            {
                                elements.RemoveAt(index1);
                                elements.RemoveAt(index2);
                            }
                            else
                            {
                                elements.RemoveAt(index2);
                                elements.RemoveAt(index1);
                            }
                        }
                        else if (elements[index1] != elements[index2])
                        {
                            Console.WriteLine("Try again!");
                        }
                    }

                }
               
                input = Console.ReadLine();
            }

            if (elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
            else if (elements.Count == 0)
            {
                Console.WriteLine($"You have won in {countGame} turns!");
            }
        }
    }
}
