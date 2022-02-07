using System;
using System.Collections.Generic;

namespace Person
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Person person = new Person
            //{
            //    Name = "Pesho",
            //    Age = 20
            //};

            //Console.WriteLine($"{person.Name} - {person.Age}");

            //Person noName = new Person();
            //Console.WriteLine($"{noName.Name} - {noName.Age}");

            //Person george = new Person(23);
            //Console.WriteLine($"{george.Name} - {george.Age}");

            //Person curtis = new Person("Curtis", 28);
            //Console.WriteLine($"{curtis.Name} - {curtis.Age}");
            

            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                var cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[0];
                int age = int.Parse(cmdArgs[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }

            //Console.WriteLine(family.GetOldestMember());

            HashSet<Person> personAbove30 = family.GetAllPeopleAbove30();
            Console.WriteLine(string.Join(Environment.NewLine, personAbove30));
        }
    }
}
