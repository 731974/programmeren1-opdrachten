using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Car
    {
        string _make, _model;
        int _year;

        public Car(string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year;
        }

        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine("Car Details");
            Console.WriteLine($"Make: {_make}");
            Console.WriteLine($"Model: {_model}");
            Console.WriteLine($"Year: {_year}");
        }
    }
}
