using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    public class Drink
    {
        public string Name;
        public double Price;
        public bool IsAlcholic;

        public Drink(string name, double price, bool isAlcoholic)
        {
            Name = name;
            Price = price;
            IsAlcholic = isAlcoholic;
        }

        public string GetDescription()
        {
            string isAlcholicText = IsAlcholic ? "(Alcoholic)" : "(Non-Alcoholic)";
            return $"{Name} - {Price:0.00} - {isAlcholicText}";
        }
    }
}
