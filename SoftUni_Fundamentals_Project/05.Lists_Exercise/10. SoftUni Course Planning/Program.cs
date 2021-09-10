using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lesson = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();


                if (command == "course start")
                {
                    break;
                }

                string[] manopulateCommand = command
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                string firstCommand = manopulateCommand[0];

                if (firstCommand == "Add")
                {
                    string addCommand = manopulateCommand[1];

                    if (!lesson.Contains(command))
                    {
                        lesson.Add(addCommand);
                    }

                }

                else if (firstCommand == "Insert")
                {
                    int insertCommand2 = int.Parse(manopulateCommand[2]);
                    string insertCommand1 = manopulateCommand[1];

                    if (insertCommand2 < 0 || insertCommand2 >= lesson.Count)
                    {
                        continue;
                    }

                    if (lesson.Contains(insertCommand1))
                    {
                        continue;
                    }

                    lesson.Insert(insertCommand2, insertCommand1);
                }

                else if (firstCommand == "Remove")
                {
                    string removeComand = manopulateCommand[1];
                    string text = removeComand + "-Exercise";

                    if (lesson.Contains(removeComand))
                    {
                        lesson.Remove(removeComand);
                    }

                    else if (lesson.Contains(removeComand + text))
                    {
                        lesson.Remove(removeComand + text);
                    }

                }

                else if (firstCommand == "Swap")
                {

                    string swapCommand1 = manopulateCommand[1];
                    string swapCommand2 = manopulateCommand[2];
                    int index1 = lesson.IndexOf(swapCommand1);
                    int index2 = lesson.IndexOf(swapCommand2);
                    
                    if (lesson.Contains(swapCommand1) && lesson.Contains(swapCommand2))
                    {
                        string lesonTitle1 = lesson.ElementAt(index1);
                        lesson[index1] = lesson[index2];
                        lesson[index2] = lesonTitle1;
                    }
                    
                    if (lesson.Contains(swapCommand1 + "-Exercise") && lesson.Contains(lesson[index1]))
                    {
                        index1 = lesson.IndexOf(swapCommand1);
                        lesson.Remove(swapCommand1 + "-Exercise");
                        lesson.Insert(index1 + 1, swapCommand1 + "-Exercise");
                    }
                    
                    else if (lesson.Contains(swapCommand2 + "-Exercise") && lesson.Contains(lesson[index2]))
                    {
                        index2 = lesson.IndexOf(swapCommand2);
                        lesson.Remove(swapCommand2 + "-Exercise");
                        lesson.Insert(index2 + 1, swapCommand2 + "-Exercise");
                    }

                }

                else if (firstCommand == "Exercise")
                {

                    string lessonTitle = manopulateCommand[1];

                    if (lesson.Contains(lessonTitle) && !lesson.Contains(lessonTitle + "-Exercise"))
                    {
                        int index = lesson.IndexOf(lessonTitle);
                        lesson.Insert(index + 1, lessonTitle + "-Exercise");
                    }
                    else if (!lesson.Contains(lessonTitle))
                    {
                        lesson.Add(lessonTitle);
                        lesson.Add(lessonTitle + "-Exercise");
                    }


                }
            }

            int n = 1;

            foreach (var str in lesson)
            {
                Console.WriteLine($"{n}.{str}");
                n++;
            }

        }
    }
}
