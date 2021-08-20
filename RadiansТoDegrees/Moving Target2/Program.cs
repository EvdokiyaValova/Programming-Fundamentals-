using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving_Target2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> target = Console.ReadLine().Split().Select(int.Parse).ToList();
        }
    }
}
