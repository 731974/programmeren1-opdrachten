using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class Rectangle
    {
        private double _width;
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value <= 0)
                    return;

                _width = value;
            }
        }

        private double _height;
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value <= 0)
                    return;

                _height = value;
            }
        }

        public double GetPerimeter()
        {
            return 2 * Height + 2 * Width;
        }

        public double GetArea() {
            return Height * Width;
        }


        public Rectangle(double width, double height) {

            Width = width;
            Height = height;

        }

        public void DisplayInfo()
        {

            double rectangleArea = GetArea();
            double rectaglePerimeter = GetPerimeter();

            Console.WriteLine("Rectangle Details:");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Area: {rectangleArea}");
            Console.WriteLine($"Perimeter: {rectaglePerimeter}");

        }

    }
}
