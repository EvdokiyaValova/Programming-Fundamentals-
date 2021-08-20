using System;

namespace Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameStudent = Console.ReadLine();
            
            int counterPoorSuccess = 0;
            int counterSuccess = 0;
            bool flag = true;
            double annualSuccess = 0;

            while (counterSuccess < 12)
            {
                double annualAssessments = double.Parse(Console.ReadLine());

                if (annualAssessments < 4)
                {
                    counterPoorSuccess++;

                    if (counterPoorSuccess == 2)
                    {
                        flag = false;
                        
                        break;
                    }
                }
                
                    annualSuccess += annualAssessments;
                    counterSuccess++;
                
            }

            if (flag == false)
            {
                Console.WriteLine($"{nameStudent} has been excluded at {counterSuccess} grade");
            }
            else
            {
                double averageSuccess = annualSuccess / counterSuccess;
                Console.WriteLine($"{nameStudent} graduated. Average grade: {averageSuccess:f2}");
            }
        }
    }
}
