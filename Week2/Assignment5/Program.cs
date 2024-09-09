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

           FindMax(firstNumber, secondNumber, thirdNumber);


        }

        int FindMax(int num1, int num2, int num3)
        {

            Console.Write(num1);


        }
    }
}
