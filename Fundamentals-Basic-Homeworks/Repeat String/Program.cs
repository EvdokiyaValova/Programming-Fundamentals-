using System;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string textInput = Console.ReadLine();
            int indexRepeat = int.Parse(Console.ReadLine());

            RepeatString(textInput, indexRepeat);
        }

        private static void RepeatString(string textInput, int indexRepeat)
        {
            for (int i = 0; i < indexRepeat; i++)
            {
                for (int j = 0; j < textInput.Length; j++)
                {
                    Console.Write(textInput[j]);
                }
            }
        }
    }
}
