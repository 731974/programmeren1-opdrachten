namespace Classes;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        //Classes worden gebruikt om voor een bepaald type verschillende functionaliteiten samen te voegen. 

        //Twee manieren om een nieuwe klas te maken, eerst initialiseren

        Person person;

        string name = "Dirk";
        int age = 18;

        person = new(name, age);

        //Alleen mogelijk als de velden op public staan
        person.Name = name;
        person.Age = age;

        //of

        person = new Person(name, age);
    }
}
