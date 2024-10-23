namespace Do_While;

class Program
{
    const string secretPassword = "wachtwoord";
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    
    }

    void Start()
    {

        //execute <statements> while (boolean) condition is true

        //Oftewel dit voert eerst iets uit en gaat daarna kijken of het de conditie waar is of niet. 
        // Handig als je bijvoorbeeld om een wachtwoord vraagt.

        bool passwordIsFalse = true;

        do
        {
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (secretPassword == password)
            {
                passwordIsFalse = false;
            }

        }
        while (passwordIsFalse);

        Console.WriteLine("Welcome user!");
    }
}
