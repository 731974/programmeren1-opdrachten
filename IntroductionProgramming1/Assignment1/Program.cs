namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //WRITE A QUESTION IN THE CONSOLE
            string name;
            Console.Write("Enter your name: ");

            //RETRIEVE THE USER INPUT FROM THE CONSOLE
            name = Console.ReadLine();

            //WRITE A QUESTION IN THE CONSOLE
            Console.Write("Enter your age: ");

            //RETRIEVE THE USER INPUT FROM THE CONSOLE
            string age = Console.ReadLine();

            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your age is " + age);

            Console.ReadKey();

        }
    }
}
