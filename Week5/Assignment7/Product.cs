using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class Product
    {
        string _name;
        double _price;

        public Product(double price, string name)
        {
            _name = name;
            _price = price;
        }

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

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                    return;
                _price = value;
            }
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine("Product Details:");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Price: {_price}");
        }
    }
}
