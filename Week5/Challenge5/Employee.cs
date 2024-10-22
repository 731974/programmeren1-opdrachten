using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    public class Employee
    {

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private double _salary;
        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }
        public double Bonus
        {
            get
            {
                return 0.1 * Salary;
            }
        }

        public Employee(string name, double salary) { 
            
            Name = name;
            Salary = salary;

        }

        public void DisplayInfo()
        {

            Console.WriteLine("Employee Details: ");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Bonus: {Bonus}");

        }

    }
}
