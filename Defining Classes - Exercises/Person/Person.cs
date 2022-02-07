using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int age)
            : this()
        {
            this.Age = age;
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Can't be below 0");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
