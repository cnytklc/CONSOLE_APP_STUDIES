using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[2]
            {
                new Student
                {
                    FirstName = "CNYT",
                    LastName = "KLC",
                    City = "IZMIR"
                },
                new Teacher
                {
                    FirstName = "KLC",
                    LastName =  "KLC",
                    City = "MANISA"
                }
            };
            foreach (Person p in person)
            {
                Console.WriteLine(p.FirstName);
            }
        Console.ReadLine(); 
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Student : Person
    {
        public string City { get; set; }
    }
    class Teacher : Person
    {
        public string City { get; set; }
    }
}
