namespace Enumerations;

class Program
{
    static void Main(string[] args)
    {

        Program program = new Program();
        program.Start();

    }

    void Start()
    {

        //Enumeraties (enums) zijn lijsten die je kunnen helpen met het formateren van user inputs
        // Enumerations zijn "strongly typed constants"

        Console.Write("Enter day of week (1-7): ");

        Days days = (Days)Enum.Parse(typeof(Days), Console.ReadLine());

        Console.WriteLine(days);
    }
}
