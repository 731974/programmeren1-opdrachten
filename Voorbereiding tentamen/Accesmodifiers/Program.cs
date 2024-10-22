namespace Accesmodifiers;

class Program
{
    static void Main(string[] args)
    {

            Program program = new Program();
        program.Start();

    }

    void Start()
    {

        Persoon persoon1 = new Persoon("Jan", "Jansen", 30, "Nederlands");

        // Toegang tot de public field en aanpassen (niet aanbevolen)
        persoon1.voornaam = "Piet";

        // Toegang tot automatische properties (get en set)
        persoon1.Achternaam = "Pietersen";
        persoon1.Leeftijd = 32;

        // Toon de informatie van de persoon
        persoon1.ToonInformatie();

        // Probeer de read-only property aan te passen (dit veroorzaakt een fout):
        // persoon1.Nationaliteit = "Duits"; // Dit is niet toegestaan

        // Wacht op een toets voordat de applicatie sluit
        Console.WriteLine("\nDruk op een toets om af te sluiten.");
        Console.ReadKey();

    }
}
