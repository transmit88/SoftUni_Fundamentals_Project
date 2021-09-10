using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    public class People
    {
        
        public string Name { get; set; }

        public int Id { get; set; }

        public int Years { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Years} years old.";
        }
    }
    public class Program
    {
        
        static void Main(string[] args)
        {
            List<People> peoples = new List<People>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] allPeople = line.Split();

                string name = allPeople[0];
                int id = int.Parse(allPeople[1]);
                int years = int.Parse(allPeople[2]);

                People people = new People()
           
                {
                    Name = name,
                    Id = id,
                    Years = years
                };

                peoples.Add(people);
            }

            List<People> sortedGrade = peoples
                .OrderBy(x => x.Years)
                .ToList();

            foreach (var people in sortedGrade)
            {
                Console.WriteLine($"{people.Name} with ID: {people.Id} is {people.Years} years old.");
            }
        }
    }
}
