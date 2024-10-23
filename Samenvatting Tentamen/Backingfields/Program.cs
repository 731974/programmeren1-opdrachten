namespace Backingfields;

class Program
{
    static void Main(string[] args)
    {

        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Product product1 = new Product("Laptop", 999.99m);
        product1.ToonInformatie();

        // Probeer een ongeldige (negatieve) prijs in te stellen
        product1.Prijs = -50;

        // De prijs zou niet veranderd moeten zijn vanwege validatie
        product1.ToonInformatie();

        // Probeer de prijs aan te passen naar een geldige waarde
        product1.Prijs = 850.75m;
        product1.ToonInformatie();

        // Wacht op input voordat de applicatie sluit
        Console.WriteLine("\nDruk op een toets om af te sluiten.");
        Console.ReadKey();

    }
}
