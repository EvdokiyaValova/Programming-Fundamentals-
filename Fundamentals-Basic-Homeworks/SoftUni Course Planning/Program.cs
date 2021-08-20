using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            string lessonTitle = Console.ReadLine();
            List<string> courseSchedule = lessonTitle
                .Split(", ").ToList();

            //           Console.WriteLine(string.Join(" ", courseSchedule));

            string[] comand = Console.ReadLine().Split(":");


            while (comand[0] != "course start")
            {
                //               string currentComand = comand;

                AddLesson(courseSchedule, comand);

                InsertLesson(courseSchedule, comand);

                RemoveLesson(courseSchedule, comand);

                SwapLessons(courseSchedule, comand);

                if (comand[0] == "Exercise")
                {
                    string[] currentLesson = comand[1].Split("-");
                    int countLesson = 0;                    
                    int indexLesson = 0;

                    int countExercise = 0;
                    int indexExercise = 0;

                    string currentExercise = currentLesson[0] + "-" + currentLesson[1];

                    for (int i = 0; i < courseSchedule.Count; i++)
                    {
                        if (currentLesson[0] == courseSchedule[i])
                        {
                            countLesson++;
                            indexLesson = i;

                        }

                        
                        if (currentExercise == courseSchedule[i])
                        {
                            countExercise ++;
                            indexExercise = i;

                        }
                    }

                    if (countLesson > 0 && countExercise == 0)
                    {
                        courseSchedule.Insert(indexLesson + 1, currentExercise);
                    }

                                  Console.WriteLine(string.Join(" ", courseSchedule));
                }

                comand = Console.ReadLine().Split(":");
            }
        }

        private static void SwapLessons(List<string> courseSchedule, string[] comand)
        {
            if (comand[0] == "Swap")
            {
                int countOneLesson = 0;
                int indexOneLesson = 0;
                for (int i = 0; i < courseSchedule.Count; i++)
                {
                    if (comand[1] == courseSchedule[i])
                    {
                        countOneLesson++;
                        indexOneLesson = i;
                    }
                }

                int countTwoLesson = 0;
                int indexTwoLesson = 0;
                for (int i = 0; i < courseSchedule.Count; i++)
                {
                    if (comand[2] == courseSchedule[i])
                    {
                        countTwoLesson++;
                        indexTwoLesson = i;
                    }
                }
                if (countOneLesson > 0 && countTwoLesson > 0)
                {
                    string temp = courseSchedule[indexOneLesson];
                    courseSchedule[indexOneLesson] = courseSchedule[indexTwoLesson];
                    courseSchedule[indexTwoLesson] = temp;
                }

 //               Console.WriteLine(string.Join(" ", courseSchedule));
            }
        }

        private static void RemoveLesson(List<string> courseSchedule, string[] comand)
        {
            if (comand[0] == "Remove")
            {
                int count = 0;
                int indexLesson = 0;

                for (int i = 0; i < courseSchedule.Count; i++)
                {
                    if (comand[1] == courseSchedule[i])
                    {
                        count++;
                        indexLesson = i;
                    }
                }

                if (count != 0)
                {
                    courseSchedule.RemoveAt(indexLesson);
                }

 //               Console.WriteLine(string.Join(" ", courseSchedule));
            }
        }

        private static void InsertLesson(List<string> courseSchedule, string[] comand)
        {
            if (comand[0] == "Insert")
            {
                int indexLesson = int.Parse(comand[2]);
                int count = 0;
                for (int i = 0; i < courseSchedule.Count; i++)
                {
                    if (comand[1] == courseSchedule[i])
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                    courseSchedule.Insert(indexLesson, comand[1]);
                }

 //               Console.WriteLine(string.Join(" ", courseSchedule));
            }
        }

        private static void AddLesson(List<string> courseSchedule, string[] comand)
        {
            if (comand[0] == "Add")
            {
                int count = 0;
                for (int i = 0; i < courseSchedule.Count; i++)
                {
                    if (comand[1] == courseSchedule[i])
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                    courseSchedule.Add(comand[1]);
                }

  //              Console.WriteLine(string.Join(" ", courseSchedule));
            }
        }
    }
}
