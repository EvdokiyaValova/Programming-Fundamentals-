using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TakeSkip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = Console.ReadLine();

            List<int> numbers = new List<int>();            
            StringBuilder result = new StringBuilder();
            List<string> text = new List<string>();

            for (int i = 0; i < original.Length; i++)
            {
                
                if (char.IsDigit(original[i]))
                {                    
                    numbers.Add(int.Parse(original[i].ToString()));
                }
                else
                {
                    text.Add(original[i].ToString());
                }
            }

//            Console.WriteLine(string.Join(" ", original));
//            Console.WriteLine(string.Join(" ", numbers));
//            Console.WriteLine(string.Join(" ", text));

            List<int> take = new List<int>();
            List<int> skip = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    take.Add(numbers[i]);
                }
                else
                {
                    skip.Add(numbers[i]);
                }                
            }

//            Console.WriteLine(string.Join(" ", take));
//            Console.WriteLine(string.Join(" ", skip));

            int indexForSkip = 0;

            for (int i = 0; i < take.Count; i++)
            {
                List<string> temp = new List<string>(text);

                temp = temp.Skip(indexForSkip).Take(take[i]).ToList();

                result.Append(string.Join("", temp));

                indexForSkip += take[i] + skip[i];
            }

            Console.WriteLine(result.ToString());
        }
    }
}
