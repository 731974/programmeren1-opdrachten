using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Circle
    {
        double _area;
        double _radius;
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }
        
        public Circle(double radius)
        {
            _radius = radius;
        }

       public double Area
        {
            get
            {
                return Math.PI * Math.Pow(_radius, 2);
            }
        }

        public void DisplayCircleInfo()
        {
            Console.WriteLine($"Radius: {_radius}");
            Console.WriteLine($"Area: {_area}");
        }
    }
}
