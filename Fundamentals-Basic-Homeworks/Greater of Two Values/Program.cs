using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeValues = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            if (typeValues == "int")
            {
                int firstInt = int.Parse(firstValue);
                int secondInt = int.Parse(secondValue);
                int result = GetMax(firstInt, secondInt);
                Console.WriteLine(result);
            }
            else if (typeValues == "char")
            {
                int firstChar = char.Parse(firstValue);
                int secondChar = char.Parse(secondValue);
                char result = (char)GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else if (typeValues == "string")
            {
                string result = GetMax(firstValue, secondValue);
                Console.WriteLine(result);
            }
        }

         static string GetMax(string firstValue, string secondValue)
        {
            int firstValueSum = 0;
            int secondValueSum = 0;

            int result = firstValue.CompareTo(secondValue);

            //for (int i = 0; i < firstValue.Length; i++)
            //{
            //    firstValueSum += firstValue[i];
            //}

            //for (int i = 0; i < secondValue.Length; i++)
            //{
            //    secondValueSum += secondValue[i];
            //}

            if (result > 0)
            {
                return firstValue;
            }
            return secondValue;
        }

        static int GetMax(int firstInt, int secondInt)
        {
            if (firstInt > secondInt)
            {
                return firstInt;
            }
            return secondInt;
        }
    }
}
