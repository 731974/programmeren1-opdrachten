namespace While;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    
    }

    void Start()
    {

        //while (boolean) condition is true, execute <statements>
        // Dit loopt dus een onbepaald aantal keer totdat aan een conditie voldaan is.
        // Handig als je bijvoorbeeld een applicatie (console) wilt maken die pas stopt als iemand een 0 in typt. 
        // Of als je een kleine game wilt maken.

        Random rnd = new Random();
        int randomNumber = rnd.Next(1, 101);
        bool guessedTheNumber = false;

        int lowCap = 1, highCap = 100;
        int amountOfGuesses = 0;

        while (!guessedTheNumber)
        {

            Console.Write($"Enter a random number between {lowCap} en {highCap}: ");
            int numberFromInput = int.Parse(Console.ReadLine());

            if (numberFromInput == randomNumber)
            {
                guessedTheNumber = true;
                break; // Om uit de lus te komen moeten we break gebruiken, niet return WANT dat stopt het programma.
            }
            else
            {
                amountOfGuesses++;

                if (numberFromInput > randomNumber)
                {
                    Console.WriteLine("Number to high, try again");

                    if (numberFromInput < highCap)
                        highCap = numberFromInput;
                }
                else
                {
                    Console.WriteLine("Number to low, try again");

                    if (numberFromInput > lowCap)
                        lowCap = numberFromInput;
                }
            }
        }

        Console.WriteLine($"Je hebt het nummer geraden in {amountOfGuesses} poging(en)");
    }
}
