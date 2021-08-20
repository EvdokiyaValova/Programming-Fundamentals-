using System;
using System.Text;


namespace The_Imitation_Game
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
                string[] comand = Console.ReadLine().Split("|");

                if (comand[0] == "Decode")
                {
                    break;
                }

                if (comand[0] == "Move")
                {
                    // •	Move {number of letters}

                    int length = int.Parse(comand[1]);
                    string word = string.Empty;

                    for (int i = 0; i < length; i++)
                    {
                        word += sb[i];
                    }
                     sb.Remove(0, length);
                     sb.Append(word);

                 //   Console.WriteLine(sb);
                }
                else if (comand[0] == "Insert")
                {
                    // •	Insert {index} {value}

                    int index = int.Parse(comand[1]);
                    string value = comand[2];

                    sb = sb.Insert(index, value);

                 //    Console.WriteLine(sb);
                }
                else if (comand[0] == "ChangeAll")
                {
                    // •	ChangeAll {substring} {replacement} 

                    string oldString = comand[1];
                    string newString = comand[2];

                    sb.Replace(oldString, newString);

                 //   Console.WriteLine(sb);
                }
            }

            Console.WriteLine($"The decrypted message is: {sb}");
        }
    }
}
