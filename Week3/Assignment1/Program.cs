namespace Assignment1
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

            Console.Write("Enter a positive integer: ");

            int number = int.Parse(Console.ReadLine());

            int answer = CalculateSum(number);

            Console.WriteLine($"The sum of natural numbers from 1 to {number} is: {answer}");
        }

        public int CalculateSum(int n)
        {
            int count = 0;
            
            for (int i = 1; i <= n; i++)
            {

                count += i + 1;

            }

            return count;
        }
    }
}
