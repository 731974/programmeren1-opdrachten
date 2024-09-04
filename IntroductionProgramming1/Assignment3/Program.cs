namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ASK AND RETRIEVE THE USER's FIRSTNAME
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            //ASK AND RETRIEVE THE USER's LASTNAME
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            //FORMAT OPTION 1
            Console.WriteLine("Your full name is " + firstName + " " + lastName);

            //FORMAT OPTION 2
            Console.WriteLine("Your full name is {0} {1} ", firstName, lastName);

            //FORMAT OPTION 3
            Console.WriteLine($"Your full name is {firstName} {lastName}");

            Console.ReadKey();


        }
    }
}
