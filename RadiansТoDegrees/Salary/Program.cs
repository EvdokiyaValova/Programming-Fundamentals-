using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            bool flag = true;

            for (int i = 1; i <= numberTabs; i++)
            {
                string nameTabs = Console.ReadLine();

                if (salary > 0)
                {
                    if (nameTabs == "Facebook")
                    {
                        salary -= 150;
                    }
                    else if (nameTabs == "Instagram")
                    {
                        salary -= 100;
                    }
                    else if (nameTabs == "Reddit")
                    {
                        salary -= 50;
                    }

                    if (salary <= 0)
                    {
                        flag = false;
                        break;
                    }
                }
                else
                {
                    flag = false;
                    break;
                }                
            }

            if (flag == true)
            {
                Console.WriteLine(salary);
            }
            else
            {
                Console.WriteLine("You have lost your salary.");
            }
        }
    }
}
