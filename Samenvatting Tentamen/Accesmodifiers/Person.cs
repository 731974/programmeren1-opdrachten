using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesmodifiers
{


class Persoon
    {
        // Public field (niet aanbevolen, maar mogelijk)
        public string voornaam;

        // Automatische properties voor Achternaam en Leeftijd
        public string Achternaam { get; set; }
        public int Leeftijd { get; set; }

        // Read-only property, alleen instelbaar in de constructor
        public string Nationaliteit { get; }

        // Computed property (berekende eigenschap)
        public string VolledigeNaam
        {
            get
            {
                return $"{voornaam} {Achternaam}";
            }
        }

        // Constructor om een Persoon-object te initialiseren
        public Persoon(string voornaam, string achternaam, int leeftijd, string nationaliteit)
        {
            this.voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Leeftijd = leeftijd;
            this.Nationaliteit = nationaliteit;
        }

        // Methode om informatie over de persoon weer te geven
        public void ToonInformatie()
        {
            Console.WriteLine($"Naam: {VolledigeNaam}");
            Console.WriteLine($"Leeftijd: {Leeftijd}");
            Console.WriteLine($"Nationaliteit: {Nationaliteit}");
        }
    }


}
