namespace Challenge3
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

            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int GCD = CalculateGCD(firstNumber, secondNumber);

            Console.WriteLine($"The GCD of {firstNumber} and {secondNumber} is: {GCD}");
        }
        
        int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
