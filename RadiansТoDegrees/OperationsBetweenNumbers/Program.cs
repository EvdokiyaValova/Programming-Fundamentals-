using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string typeOperator = Console.ReadLine();

            double result = 0;
            string typeResult = "";
            bool flag = true;

            switch (typeOperator)
            {
                case "+":
                    result = n1 + n2;
                    if (result % 2 == 0)
                    {
                        typeResult = "even";
                    }
                    else
                    {
                        typeResult = "odd";
                    }
                    Console.WriteLine($"{n1} + {n2} = {result} - {typeResult}");
                    break;
                case "-":
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        typeResult = "even";
                    }
                    else
                    {
                        typeResult = "odd";
                    }
                    Console.WriteLine($"{n1} - {n2} = {result} - {typeResult}");
                    break;
                case "*":
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        typeResult = "even";
                    }
                    else
                    {
                        typeResult = "odd";
                    }
                    Console.WriteLine($"{n1} * {n2} = {result} - {typeResult}");
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        flag = false;
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        result = n1 * 1.00 / n2;

                        Console.WriteLine($"{n1} / {n2} = {result:f2}");
                    }
                    break;
                case "%":
                    if (n2 == 0)
                    {
                        flag = false;
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        result = n1 % n2;

                        Console.WriteLine($"{n1} % {n2} = {result}");
                    }
                    break;
            }

        }
    }
}
