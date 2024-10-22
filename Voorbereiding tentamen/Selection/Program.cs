namespace Selection;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {

        //If Else selectie, let op met het gebruik van else if, laatste else moet altijd een else zijn!
        var number = 1;

        if (number == 1)
        {
            Console.WriteLine("number is 1");
        } else
        {
            Console.WriteLine("number is not 1");
        }

        // || OR
        // && AND
        // ! INVERSE (!TRUE = FALSE)


        bool isTrue = false;
        string text = isTrue ? "true" : "false";

        //Advanced method /\

        switch(text)
        {
            case "true":
                Console.WriteLine(true);
                break;
            case "false":
                Console.WriteLine(false);
                break;
            default:
                break;
        }
        //DO NOT FORGET THE DEFAULT!!

        //Case kan ook een vergelijking zijn
        Random rnd = new Random();
        number += rnd.Next();
        switch (number)
        {

            case < 0:
                Console.WriteLine($"{number} is less then zero");
                break;
            case 0:
                Console.WriteLine($"{number} is 0");
                break;
            case > 0:
                Console.WriteLine($"{number} is bigger then zero");
                break;
            default:
                throw new Exception("Error occured");
        }

        //LET OP!! DIT IS GEEN GOED VOORBEELD VOOR EEN SWITCH
        // Switch gebruik je na 3 of selecties, hiervoor moet je een if if else else gebruiken!
    }
}

