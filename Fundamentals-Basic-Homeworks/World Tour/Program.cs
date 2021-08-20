using System;
using System.Text;

namespace World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(input[i]);
            }


            while (true)
            {
                string[] comand = Console.ReadLine().Split(":");

                if (comand[0] == "Travel")
                {
                    break;
                }

                // Add Stop:{index}:{string} 
                if (comand[0] == "Add Stop")
                {
                    int index = int.Parse(comand[1]);
                    string substring = comand[2];

                    if (index >= 0 && index < sb.Length)
                    {
                        sb.Insert(index, substring);
                    }

                    Console.WriteLine(sb);
                }
                else if (comand[0] == "Remove Stop")
                {
                    // 	Remove Stop:{start_index}:{end_index} 

                    int startIndex = int.Parse(comand[1]);
                    int endIndex = int.Parse(comand[2]);

                    int length = endIndex - startIndex;

                    if (startIndex >= 0 && startIndex < sb.Length && endIndex >= 0 && endIndex < sb.Length)
                    {
                        sb.Remove(startIndex, length+1);
                    }

                    Console.WriteLine(sb);
                }
                else if (comand[0] == "Switch")
                {
                    // 	Switch:{old_string}:{new_string} 

                    string oldString = comand[1];
                    string newString = comand[2];

                    sb.Replace(oldString, newString);

                    Console.WriteLine(sb);
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {sb}");
        }
    }
}
