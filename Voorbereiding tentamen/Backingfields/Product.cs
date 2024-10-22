using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backingfields
{
    class Product
    {
        // Private backing field voor de Prijs
        private decimal _prijs;

        // Property voor Prijs met een backing field
        public decimal Prijs
        {
            get
            {
                return _prijs;
            }
            set
            {
                // Validatie: prijs mag niet negatief zijn
                if (value < 0)
                {
                    Console.WriteLine("Fout: De prijs kan niet negatief zijn.");
                }
                else
                {
                    _prijs = value;
                }
            }
        }

        // Automatische property voor de Naam van het product
        public string Naam { get; set; }

        // Constructor om het product te initialiseren
        public Product(string naam, decimal prijs)
        {
            Naam = naam;
            Prijs = prijs;  // Gaat via de property (dus inclusief validatie)
        }

        // Methode om productinformatie weer te geven
        public void ToonInformatie()
        {
            Console.WriteLine($"Product: {Naam}");
            Console.WriteLine($"Prijs: {Prijs:C}");
        }
    }
}
