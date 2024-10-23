namespace RandomInteger;

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

        //Om een random getal te genereren maken we gebruik van de Random Class.

        Random rnd = new Random();

        //Om nu een random getal te maken, creeëren we een integer die gebruik maakt van de Random class. 

        int randomNumber = rnd.Next(1, 100);

        // LET OP dat bij next het eerste getal het kleinste getal is, het tweede getal het grootste.
        // Maar die doet niet mee. Dus er staat 1<= x > 100. 
        // Oftewel x (het random getal) ligt tussen 1 en 99, want 100 doet niet mee.

        Console.WriteLine(randomNumber);
    }
}
