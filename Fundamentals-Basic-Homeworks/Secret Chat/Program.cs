using System;
using System.Linq;
using System.Text;

namespace Secret_Chat
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

            string message = sb.ToString();

 //           Console.WriteLine(message);

            while (true)
            {
                string comand = Console.ReadLine();

                if (comand == "Reveal")
                {
                    break;
                }

                string[] currentComand = comand.Split(":|:").ToArray();

                if (currentComand[0] == "InsertSpace")
                {
                    // •	InsertSpace:|:{index}

                    int index = int.Parse(currentComand[1]);
                    sb.Insert(index, " ");

                    message = sb.ToString();

                    Console.WriteLine(message);
                }
                else if(currentComand[0] == "Reverse")
                {
                    // •	Reverse:|:{substring}

                    string substring = currentComand[1];

                    if (message.IndexOf(substring) > -1)
                    {
                        string reverseSubstring = string.Empty;
                        int index = message.IndexOf(substring);
                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            reverseSubstring +=substring[i];
                        }
                        //  Console.WriteLine(reverseSubstring);

                        sb.Remove(index, substring.Length);
                        sb.Append(reverseSubstring);
                        message = sb.ToString();

                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
                else if (currentComand[0] == "ChangeAll")
                {
                    // •	ChangeAll:|:{substring}:|:{replacement} 

                    sb.Replace(currentComand[1], currentComand[2]);

                    message = sb.ToString();

                    Console.WriteLine(message);
                }
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
