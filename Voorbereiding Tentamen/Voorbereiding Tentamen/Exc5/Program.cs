namespace Exc5
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

            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"First number is {firstNumber}");

            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Second number is {secondNumber}");

            SwapNumbers(ref firstNumber, ref secondNumber);

            Console.WriteLine($"After swap first number ({firstNumber}) and second number ({secondNumber})");
        }

        void SwapNumbers(ref int x, ref int y) { 
        
            int temp  = x;
            x = y;
            y = temp;
        }
    }
}
