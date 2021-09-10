using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split();

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string city = tokens[3];

                Students student = new Students();

                student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

                if (student == null)
                {
                    Students student1 = new Students();

                    student1.FirstName = firstName;
                    student1.LastName = lastName;
                    student1.Age = age;
                    student1.City = city;

                    students.Add(student1);
                }

                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = city;
                }

                line = Console.ReadLine();
            }

            string filterCity = Console.ReadLine();

            List<Students> filterStudents = students
                .Where(s => s.City == filterCity)
                .ToList();

            foreach (var student in filterStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
