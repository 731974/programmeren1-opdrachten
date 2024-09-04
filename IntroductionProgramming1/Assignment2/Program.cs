namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your age: ");
             string input = Console.ReadLine();

             //Convert the 'string' input to an integer
             int age = int.Parse(input);

             age += 1;

            //Convert the 'integer' to an string
            string output = age.ToString();

            Console.WriteLine("Next year you will be " + age + " years old.");

            Console.ReadKey();
        }
    }
}
