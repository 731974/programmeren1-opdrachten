namespace Assignment3
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
            Console.Write("Enter an integer: ");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication table of {number}:");
            PrintMultiplicationTable(number);
        }

        public void PrintMultiplicationTable(int number)
        {

            for (int i = 1; i <= 10; i++) 
            {

                int answer = i * number;

                Console.WriteLine($"{i} x {number} = {answer}");

            }
        }
    }
}
