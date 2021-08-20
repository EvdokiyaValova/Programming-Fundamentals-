using System;

namespace Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberLines = int.Parse(Console.ReadLine());

            char[] arrMessage = new char[numberLines];
            for (int i = 0; i < arrMessage.Length; i++)
            {
                arrMessage[i] = char.Parse(Console.ReadLine());                
            }

            for (int i = 0; i < arrMessage.Length; i++)
            {
                arrMessage[i] = (char)(arrMessage[i] + key);
                Console.Write(arrMessage[i]);
            }

        }
    }
}
