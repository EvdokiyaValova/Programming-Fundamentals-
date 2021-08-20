using System;
using System.Collections.Generic;
using System.Linq;

namespace Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> line2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> newLine = new List<int>();

            int index1 = 0;
            int index2 = line2.Count - 1;
            for (int i = 0; i < line2.Count + line1.Count - 2; i++)
            {
                if (i % 2 == 0)
                {
                    newLine.Add(line1[index1]);
                    index1++;
                }
                else
                {
                    newLine.Add(line2[index2]);
                    index2--;
                }
            }

            int limited1 = 0;
            int limited2 = 0;

            if (line1.Count > line2.Count)
            {
                limited1 = line1[line1.Count - 1];
                limited2 = line1[line1.Count - 2];
            }
            else
            {
                limited1 = line2[0];
                limited2 = line2[1];
            }
            
            List<int> result = new List<int>();
            int start = Math.Min(limited1, limited2);
            int end = Math.Max(limited1, limited2);

            for (int i = 0; i < newLine.Count; i++)
            {
                int current = newLine[i];

                if (current > start && current < end)
                {
                    result.Add(current);
                }
            }

            result.Sort();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
