namespace Assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {

            //Ask the user to input a non-negative integer
            Console.Write("Enter a non-negative integer: ");

            int number = int.Parse(Console.ReadLine());

            int calculateFactorial = CalculateFactorial(number);

            Console.WriteLine($"The factorial of {number} is: {calculateFactorial}");

        }

        public int CalculateFactorial(int n)
        {
            int count = 1;

            for (int i = 1; i <= n; i++)
            {

                count = count * i;

            }

            return count;
        }
    }
}
