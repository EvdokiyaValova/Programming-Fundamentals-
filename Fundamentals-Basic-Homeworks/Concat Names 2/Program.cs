using System;

namespace Concat_Names_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] concatNames = new string[3];

            for (int i = 0; i < concatNames.Length; i++)
            {
                concatNames[i] = Console.ReadLine();
            }

            string[] newConcatName = new string[3];

            newConcatName[0] = concatNames[0];
            newConcatName[1] = concatNames[2];
            newConcatName[2] = concatNames[1];

            for (int i = 0; i < newConcatName.Length; i++)
            {
                Console.Write(newConcatName[i]);
            }
        }
    }
}
