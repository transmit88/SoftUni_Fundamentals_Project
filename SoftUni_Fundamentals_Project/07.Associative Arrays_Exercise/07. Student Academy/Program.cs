using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentNmae = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentNmae))
                {
                    students.Add(studentNmae, new List<double>());
                }

                students[studentNmae].Add(grade);
            }

            Dictionary<string, List<double>> sortedStudents = students
                .Where(s => s.Value.Average() >= 4.50)
                .OrderByDescending(s => s.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
            }

            //Dictionary<string, double> sortedStudents = students
            //  .Select(s => KeyValuePair<string, double>(s.Key, s.Value.Average()))
            //  .Where(s => s.Value >= 4.5)
            //  .OrderByDecending(s => s.Va;ue)
            //  .ToDictionary(x => x.Key, x => x.Value)
            //
        }
    }
}
