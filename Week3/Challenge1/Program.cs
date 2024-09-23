namespace Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            program.Start();

        }

        void Start()
        {

            Console.Write("Enter the number of terms: ");
            int number = int.Parse(Console.ReadLine());

            GenerateFibonacci(number);
        }

        void GenerateFibonacci(int terms)
        {
            string sequence = "";
            int prev = 1;
            int current = 1;
            Console.WriteLine("Fibonacci sequence:");

            for (int i = 1; i <= terms; i++)
            {
                Console.Write($"{prev} ");
                int next = prev + current;
                prev = current;
                current = next;
            }
        }
    }
}
