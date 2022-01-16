using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            List<Person> people = new List<Person>();

            while (command[0] != "End")
            {
                string currentName = command[0];
                int currentID = int.Parse(command[1]);
                int currentAge = int.Parse(command[2]);

                if (people.Any(person => person.ID == currentID))
                {
                    Person person = UpdatedPerson(people, currentID);
                    person.Name = currentName;
                    person.ID = currentID;
                    person.Age = currentAge;
                }
                else
                {
                    Person person = new Person();
                    person.Name = currentName;
                    person.ID = currentID;
                    person.Age = currentAge;
                    people.Add(person);
                }
                command = Console.ReadLine().Split();
            }

            foreach (Person person in people.OrderBy(person => person.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
        static Person UpdatedPerson(List<Person> people, int id)
        {
            Person existingPerson = null;
            foreach (Person person in people)
            {
                if (person.ID == id)
                {
                    existingPerson = person;
                }
            }
            return existingPerson;
        }
    }
}