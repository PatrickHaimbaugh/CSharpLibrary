using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_with_constructors
{
    public class Person
    {
        public string name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Person(
            string Name,
            string Gender,
            int Age
            )
        {
            Console.WriteLine($"Creating new Person");
            name = Name;
            gender = Gender;
            age = Age;

        }
    }
}
