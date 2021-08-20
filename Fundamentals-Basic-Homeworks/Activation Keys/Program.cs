using System;
using System.Collections.Generic;
using System.Linq;

namespace Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();            

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Generate")
                {
                    break;
                }

                List<string> instructions = input.Split(">>>").ToList();
                

                if (instructions[0] == "Contains")
                {
                    string sb = instructions[1];

                    if (rawActivationKey.Contains(sb))
                    {
                        Console.WriteLine($"{rawActivationKey} contains {sb}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                if (instructions[0] == "Flip")
                {
                    int startIndex = int.Parse(instructions[2]);
                    int endIndex = int.Parse(instructions[3]);
                    string sb = rawActivationKey.Substring(startIndex, endIndex - startIndex);

                    if (instructions[1] == "Upper")
                    {
                        string sbNew = sb.ToUpper();
                        rawActivationKey = rawActivationKey.Replace(sb, sbNew);
                        Console.WriteLine(rawActivationKey);
                    }
                    else if (instructions[1] == "Lower")
                    {
                        string sbNew = sb.ToLower();
                        rawActivationKey = rawActivationKey.Replace(sb, sbNew);
                        Console.WriteLine(rawActivationKey);
                    }
                }


                if (instructions[0] == "Slice")
                {
                    int startIndex = int.Parse(instructions[1]);
                    int endIndex = int.Parse(instructions[2]);
                    rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);

                    Console.WriteLine(rawActivationKey);
                }
            }

            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}
