using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planning2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();
            string comand = Console.ReadLine();

            while (comand != "course start")
            {
                List<string> currentComand = comand.Split(":").ToList();

                if (currentComand[0] == "Add")
                {

                    List<string> currentLessonComand = currentComand[1].Split("-").ToList();
                    int count = 0;

                    for (int i = 0; i < lessons.Count; i++)
                    {
                        List<string> currentLesson = lessons[i].Split("-").ToList();

                        if (currentLessonComand[0] == currentLesson[0])
                        {
                            count++;
                        }
                    }

                    if (count == 0)
                    {
                        lessons.Add(currentLessonComand[0]);
                    }
                }
                else if (currentComand[0] == "Insert")
                {
                    List<string> currentLessonComand = currentComand[1].Split("-").ToList();
                    int count = 0;

                    for (int i = 0; i < lessons.Count; i++)
                    {
                        List<string> currentLesson = lessons[i].Split("-").ToList();

                        if (currentLessonComand[0] == currentLesson[0])
                        {
                            count++;
                        }
                    }

                    int indexNewLesson = int.Parse(currentComand[2]);

                    if (count == 0 && indexNewLesson >= 0 && indexNewLesson < lessons.Count)
                    {
                        lessons.Insert(indexNewLesson, currentLessonComand[0]);
                    }
                }
                else if (currentComand[0] == "Remove")
                {
                    List<string> currentLessonComand = currentComand[1].Split("-").ToList();
                    int count = 0;

                    for (int i = 0; i < lessons.Count; i++)
                    {
                        List<string> currentLesson = lessons[i].Split("-").ToList();

                        if (currentLessonComand[0] == currentLesson[0])
                        {
                            lessons[i] = "for deleting";
                        }
                    }

                    lessons.Remove("for deleting");
                }
                else if (currentComand[0] == "Swap")
                {
                    string firstLesson = currentComand[1];
                    string secondLesson = currentComand[2];
                    if (lessons.Exists(x => x == firstLesson) && lessons.Exists(x => x == secondLesson))
                    {
                        int firstIndex = lessons.IndexOf(firstLesson);
                        int secondIndex = lessons.IndexOf(secondLesson);
                        lessons[firstIndex] = secondLesson;
                        lessons[secondIndex] = firstLesson;

                        if (lessons.Contains($"{firstLesson}-Exercise"))
                        {
                            lessons.Remove($"{firstLesson}-Exercise");
                            int indexOfFirstLesson = lessons.IndexOf(firstLesson);
                            lessons.Insert(indexOfFirstLesson + 1, $"{firstLesson}-Exercise");
                        }

                        if (lessons.Contains($"{secondLesson}-Exercise"))
                        {
                            lessons.Remove($"{secondLesson}-Exercise");
                            int indexOfSecondLesson = lessons.IndexOf(secondLesson);
                            lessons.Insert(indexOfSecondLesson + 1, $"{secondLesson}-Exercise");
                        }
                    }
                    else
                    {
                        continue;
                    }
                }                   
            
                else if (currentComand[0] == "Exercise")
                {
                    List<string> currentLessonComand = currentComand[1].Split("-").ToList();
                    int count = 0;
                    int index = 0;

                    for (int i = 0; i < lessons.Count; i++)
                    {
                        List<string> currentLesson = lessons[i].Split("-").ToList();
                        string exercise = currentComand[1];

                        if (exercise == lessons[i])
                        {
                            count++;
                            index = i;
                        }
                    }

                    if (count == 0)
                    {
                        string newExercise = currentComand[1] + "-" + "Exercise";
                        lessons.Add(currentComand[1]);
                        lessons.Add(newExercise);
                    }
                    else if (count == 1)
                    {
                        string newExercise = currentComand[1] + "-" + "Exercise";
                        lessons.Insert(index + 1, newExercise);
                    }
                }

                comand = Console.ReadLine();
            }
            int number = 1;
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{number}.{lessons[i]}");
                number++;
            }
  //          Console.WriteLine(string.Join(" ", lessons));
        }
    }
}
