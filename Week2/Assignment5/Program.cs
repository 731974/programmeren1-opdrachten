namespace Assignment5
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

            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            int highestNumber = FindMax(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine($"The largest number is {highestNumber}");

        }

        public int FindMax(int num1, int num2, int num3)
        {
            int highestNumber = num1;

            if(highestNumber < num2)
            {
                highestNumber = num2;
            }

            if (highestNumber < num3)
            {
                highestNumber = num3;
            }

            return highestNumber;
        }
    }
}
