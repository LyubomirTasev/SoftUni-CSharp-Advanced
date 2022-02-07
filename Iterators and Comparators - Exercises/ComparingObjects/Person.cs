using System;
using System.Collections.Generic;
using System.Text;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public string Name;
        public int Age;
        public string Town;

        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public int CompareTo(Person other)
        {
            int result = Name.CompareTo(other.Name);

            if (result == 0)
            {
                result = Age.CompareTo(other.Age);
            }
            if (result == 0)
            {
                result = Town.CompareTo(other.Town);
            }

            return result;
        }
    }
}
