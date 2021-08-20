using System;
using System.Collections.Generic;
using System.Linq;

namespace LadyBugs2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenfhtField = int.Parse(Console.ReadLine());
            List<int> indexStartBugs = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> field = new List<int>();
            for (int i = 0; i < lenfhtField; i++)
            {
                field.Add(0);
            }

            for (int i = 0; i < indexStartBugs.Count; i++)
            {
                if (indexStartBugs[i] >= 0 && indexStartBugs[i] < field.Count)
                {
                    field[indexStartBugs[i]] = 1;
                }
            }

            string comand = Console.ReadLine();

            while (comand != "end")
            {
                List<string> currentComand= comand.Split().ToList();
                int index = int.Parse(currentComand[0]);
                string direction = currentComand[1];
                int fly = int.Parse(currentComand[2]);

                if (index >= 0 && index < field.Count && field[index] == 1 && fly != 0) // в полето е, има калинка и лети
                {                    
                    if (direction == "right") // надясно
                    { 
                        if (index + fly >= 0 && index + fly < field.Count && field[index + fly] == 0) // новата позиция е в полето и е празна
                        {
                            field[index + fly] = 1;
                        }
                        else if (index + fly >= 0 && index + fly < field.Count && field[index + fly] == 1) // новата позиция е в полето и е заета
                        {
                            while ( index + fly >= 0 && index + fly < field.Count && field[index + fly] == 1) // докато новата позиция е в полето и е заета
                            {
                                fly += fly;
                                if (index + fly >= 0 && index + fly < field.Count && field[index + fly] == 0)
                                {
                                    field[index + fly] = 1;
                                    break;
                                }
                            }
                        }                        
                    }
                    else if(direction == "left")
                    {  
                        if (index - fly >= 0 && index - fly < field.Count && field[index - fly] == 0)
                        {
                            field[index - fly] = 1;
                        }
                        else if (index - fly >= 0 && index - fly < field.Count && field[index - fly] == 1)
                        {
                            while(index - fly >= 0 && index - fly < field.Count && field[index - fly] == 1)
                            {
                                fly += fly;
                                if (index - fly >= 0 && index - fly < field.Count && field[index - fly] == 0)
                                {
                                    field[index - fly] = 1;
                                    break;
                                }
                            }
                        }
                    }

                    field[index] = 0;
                }                
                comand = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
