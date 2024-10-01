using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Person
    {

        public string Name { get; set; }
        string _name;
        public int Age { get; set; }
        int _age;

        public Person(int age, string name)
        {
            Name = name;
            _name = name;
            _age = age;
            Age = age;
        }

       public void DisplayInfo()
        {

            Console.WriteLine($"{Name} is {Age} jaar oud");

        }

    }
}
