using System;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int lastDidjit = 0;
            bool flag = false;
            for (int i = 1; i <= n; i++)
            {
                lastDidjit = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                flag = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", lastDidjit, flag);
                sum = 0;
                i = lastDidjit;
            }

        }
    }
}
