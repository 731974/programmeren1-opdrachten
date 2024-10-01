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
       public double Radius;
        
        public Circle(double radius)
        {

            Radius = radius;

        }

       public double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }

        public void DisplayCircleInfo()
        {
            Console.WriteLine($"Radius: {Radius}");

            Console.WriteLine($"Area: {Area}");

        }
    }
}
