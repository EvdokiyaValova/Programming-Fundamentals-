using System;
using System.Collections.Generic;

namespace _01._Problem_Programming_Fundamentals_Final_Exam___14_August_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {
                string[] comand = Console.ReadLine().Split();

                if (comand[0] == "Complete")
                {
                    break;
                }
                else if (comand[0] == "Make")
                {
                    if (comand[1] == "Upper")
                    {
                        input = input.ToUpper();

                        Console.WriteLine(input);
                    }
                    else if (comand[1] == "Lower")
                    {
                        input = input.ToLower();

                        Console.WriteLine(input);
                    }
                }
                else if (comand[0] == "GetDomain")
                {
                    int number = int.Parse(comand[1]);
                    int index = input.Length - number;

                    string substring = input.Substring(index);

                    Console.WriteLine(substring);
                }
                else if (comand[0] == "GetUsername")
                {
                    bool have = false;
                    int index = 0;
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == '@')
                        {
                            have = true;
                            index = i;
                        }
                    }

                    if (have == false)
                    {
                        Console.WriteLine($"The email {input} doesn't contain the @ symbol.");
                    }
                    else
                    {
                        string substring = input.Substring(0, index);

                        Console.WriteLine(substring);
                    }
                }
                else if (comand[0] == "Replace")
                {
                    string simbol = comand[1];

                    input = input.Replace(simbol, "-");

                    Console.WriteLine(input);
                }
                else if (comand[0] == "Encrypt")
                {
                    List<int> result = new List<int>();

                    for (int i = 0; i < input.Length; i++)
                    {
                        result.Add(input[i]);
                    }

                    Console.WriteLine(string.Join(" ", result));
                }
            }
        }
    }
}
