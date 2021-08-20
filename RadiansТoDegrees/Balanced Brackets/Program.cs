using System;

namespace Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersLines = int.Parse(Console.ReadLine());

            string[] randomString = new string[numbersLines];

            for (int i = 0; i < randomString.Length; i++)
            {
                randomString[i] = Console.ReadLine();
            }

            //int opnenCounter = 0;
            //int IndexOpen = 0;
            //int closeCounter = 0;
            //int IndexClosed = 0;
            bool isOpen = false;
            bool isClose = false;
            for (int i = 0; i < randomString.Length; i++)
            {
                if (randomString[i] == "(")
                {
                    if (isClose == false && isOpen == false)
                    {
                        isOpen = true;
                    }
                    else if (isClose == true && isOpen == true)
                    {
                        isOpen = true;
                        isClose = false;
                    }
                    else
                    {
                        isOpen = false;
                    }
                }
                else if (randomString[i] == ")")
                {
                    if (isOpen == true && isClose == false)
                    {
                        isClose = true;

                    }
                    else if (isOpen == false)
                    {
                        isClose = false;
                        break;
                    }
                    else
                    {
                        isClose = false;
                    }
                }


            }

            if (isOpen == true && isClose == true)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
