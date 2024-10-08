using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Person
    {
        string _name;
        public string Name { get
            {
                return _name;
            } set {
                _name = value;
            } 
        }

        int _age;
        public int Age { get
            {
                return _age;
            }
            set {
                _age = value;
            } 
        }

        public Person(int age, string name)
        {
            _name = name;
            _age = age;
        }

       public void DisplayInfo()
        {
            Console.WriteLine($"{Name} is {Age} jaar oud");
        }
    }
}
