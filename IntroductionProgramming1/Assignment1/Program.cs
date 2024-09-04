namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ASK THE NAME OF THE USER (CONSOLE)
            string name;
            Console.Write("Enter your name: ");

            //RETRIEVE THE USER INPUT FROM THE CONSOLE
            name = Console.ReadLine();

            //ASK THE AGE OF THE USER (CONSOLE)
            Console.Write("Enter your age: ");

            //RETRIEVE THE USER INPUT FROM THE CONSOLE
            string age = Console.ReadLine();

            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your age is " + age);

            Console.ReadKey();

        }
    }
}
