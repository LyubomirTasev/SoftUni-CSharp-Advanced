using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string[] tokens = Console.ReadLine().Split();
                if (tokens[0] == "END")
                {
                    break;
                }
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                people.Add(new Person(name, age, town));
            }

            int index = int.Parse(Console.ReadLine()) - 1;
            int equal = 0;
            int notEqual = 0;

            foreach (Person person in people)
            {
                if (people[index].CompareTo(person) == 0)
                {
                    equal++;
                }
                else
                {
                    notEqual++;
                }
            }

            if (equal <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equal} {notEqual} {people.Count}");
            }
        }
    }
}
