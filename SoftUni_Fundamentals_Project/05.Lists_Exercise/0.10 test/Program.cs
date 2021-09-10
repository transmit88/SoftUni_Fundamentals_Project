using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. read schedule, seperated by ", "
            List<string> schedule = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> exercises = new List<string>();

            // 2. while(input != "course start") ----> read comands
            string input = Console.ReadLine();
            while (input != "course start")
            {
                string[] commandParts = input
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                switch (commandParts[0])
                {
                    // 2.1 Add:{lessonTitle} – add the lesson to the end of the schedule, if it does not exist.
                    case "Add":
                        string newLessonTitle = commandParts[1];
                        if (!schedule.Contains(newLessonTitle))
                        {
                            schedule.Add(newLessonTitle);
                        }
                        break;

                    // 2.2 Insert:{lessonTitle}:{index} – insert the lesson to the given index, if it does not exist.
                    case "Insert":
                        newLessonTitle = commandParts[1];
                        int index = int.Parse(commandParts[2]);
                        if (!schedule.Contains(newLessonTitle))
                        {
                            schedule.Insert(index, newLessonTitle);
                        }
                        break;

                    // 2.3 Remove:{lessonTitle} – remove the lesson, if it exists.
                    case "Remove":
                        newLessonTitle = commandParts[1];
                        if (schedule.Contains(newLessonTitle))
                        {
                            schedule.Remove(newLessonTitle);
                        }
                        break;

                    // 2.4 Swap:{lessonTitle}:{lessonTitle} – change the place of the two lessons, if they exist.
                    case "Swap":
                        string lesson1 = commandParts[1];
                        string lesson2 = commandParts[2];
                        Swap(schedule, lesson1, lesson2);
                        break;

                    // 2.5 Exercise:{lessonTitle} – add Exercise in the schedule right after the lesson index,
                    case "Exercise":
                        newLessonTitle = commandParts[1];
                        AddExercise(newLessonTitle, schedule, exercises);
                        break;
                }
                input = Console.ReadLine();
            }
            Print(schedule, exercises);
        }

        private static void AddExercise(string newLessonTitle, List<string> schedule, List<string> exercises)
        {
            // 2.5.1 if the lesson exists and there is no exercise already,"{lessonTitle}-Exercise". 
            if (schedule.Contains(newLessonTitle) &&
                !schedule.Contains($"{newLessonTitle}-Exercise"))
            {
                exercises.Add($"{newLessonTitle}-Exercise");
            }
            // 2.5.2 If the lesson doesn`t exist, schelude.add(lesson), followed by the Exercise.
            else if (!schedule.Contains(newLessonTitle))
            {
                schedule.Add(newLessonTitle);
                exercises.Add($"{newLessonTitle}-Exercise");
            }
        }

        private static void Print(List<string> schedule, List<string> exercises)
        {
            int i = 1;
            foreach (var item in schedule)
            {
                Console.WriteLine($"{i}.{item}");
                if (exercises.Contains($"{item}-Exercise"))
                {
                    i++;
                    Console.WriteLine($"{i}.{item}-Exercise");
                }
                i++;
            }
        }

        private static void Swap(List<string> schedule, string lesson1, string lesson2)
        {
            // 2.4.1 swap Lessons
            if ((schedule.Contains(lesson1)) && (schedule.Contains(lesson2)))
            {
                string temp = lesson1;
                int index1 = schedule.IndexOf(lesson1);
                int index2 = schedule.IndexOf(lesson2);
                schedule[index1] = lesson2;
                schedule[index2] = temp;
            }

            // 2.4.2 swap Exercise, if they exists
            /*
            MoveExercise(schedule, lesson1);
            MoveExercise(schedule, lesson2);
            */

        }

        private static void MoveExercise(List<string> schedule, string lesson)
        {
            if (schedule.Contains($"{lesson}-Exercise"))
            {
                string temp = $"{lesson}-Exercise";
                schedule.Remove($"{lesson}-Exercise");
                int lessonIndex = schedule.IndexOf(lesson);
                schedule.Insert(lessonIndex + 1, temp);
            }
        }
    }
}