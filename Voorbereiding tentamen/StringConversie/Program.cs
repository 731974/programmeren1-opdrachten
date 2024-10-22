namespace StringConversie;

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
        string name = "Thijs";
        int age = 19;
        // Om een variable te printen naar de Console hebben we verschillende mogelijkheden.

        // Optie 1 | Hierbij print je alleen de variabele name, maar wordt er geen witregel (\n) achter geplakt. 
        //           Dus de volgende Console.Write() zal er direct acter komen
        Console.Write(name);


        // Optie 2 | Hierbij print je een stuk met daarna een witregel. Er staat dus (string \n) Daarom komt dit direct achter de vorige {name} te staan.
        Console.WriteLine(name);


        // Optie 3 | Hierbij zet je iets voor de naam, deze methode wordt niet aangeraden.
        Console.WriteLine($"De naam is: " + name);


        // Optie 4 | Doormiddel van de {} kan je de variable later gedefineerd omdraaien, zie het verschil in output beneden.
        Console.WriteLine("Naam, Leeftijd {1} {0}:", name, age);  // (Thijs 19)
        Console.WriteLine("Naam, Leeftijd {0} {1}:", name, age);  // (19 Thijs)


        // Optie 5 | Doormiddel van de $ in combinatie met de {} kan je variabele direct in een string printen.
        Console.WriteLine($"Naam: {name}, Age: {age}");


        // Optie 6 | Als je meerdere lijnen wilt printen kan je twee manieren gebruiken. 
        //           Via een @ selector of via meerdere Console.WriteLine() elementen.

        Console.WriteLine($@"Naam: {name}
Age: {age}"); // LET OP | Het klopt dat je uitlijning niet meer klopt, als je spaties voor de Age doet, wordt dat ook verkeerd uitgelijnd in de Console. 
              //          Zo laten staan dus. Zie ook dat je meerdere selectoren kunt gebruiken @$ in combinatie met elkaar laat je dus schrijven over
              //          regels en direct in de string variabel toevoegen.

        Console.WriteLine($"Naam: {name}");
        Console.WriteLine($"Age: {age}");

        //Komma getallen uitprinten kan via de F selector met daarna het getal aan gewenst aantal decimalen F2 (2 decimalen) F3 (3 decimalen) etc...
        // Of door een :0.00 met het aantal nullen achter de punt als aantal decimalen. 0.00 (2) 0.000 (3) etc...


    }
}
