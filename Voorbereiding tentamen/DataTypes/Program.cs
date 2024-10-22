namespace DataTypes;

class Program
{
    static void Main(string[] args)
    {
        //Default setup
        Program program = new Program();
        program.Start();
    }
    
    void Start()
    {

        // int (integer) staat voor gehele positieve of negatieve getallen (-200, -100, 0, 100, 200)
        // Let op, int kan niet enorm grote getallen krijgen. 
        // Het bereik loopt van -2.147.483.648 tot 2.147.483.647

        int number = 0;


        // string staat voor tekst groter dan 1 character en wordt gekenmerkt door de ""
        string name = "Oefen Tentamen";


        // char (character) staat voor één character en wordt gekenmerkt door de ''
        char character = 'a';


        // double kan decimalen opvangen en heeft het grootste bereik. 
        // Let op, als je twee integere getallen hebt maar double als datatype hebt, maakt C# er toch een int van, 
        // om dat te voorkomen plaats een (double) voor een van de twee integere getallen of door een .0 toe te voegen.
        double decimalNumber = 10.5;
        double result = 10 / (double)5;


        // float kan decimale getallen opslaan, maar met minder precisie dan double.
        float biggerNumber = 10000000000F;
        Console.WriteLine(biggerNumber);

        // Je kan hetzelfde ook bereiken door een long te gebruiken voor lange nummers
        long biggestNumber = 1000000000000L;
        Console.WriteLine(biggestNumber);


        //Door een letter erachter te zetten kan je het ook conventeren D (double) F (float) L (long)
    }

}
