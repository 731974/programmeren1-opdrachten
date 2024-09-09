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

            int FindMax(int num1, int num2, int num3)
        {
            int highestNumber;

            if (num1 > num2 && num1 > num3)
            {

                highestNumber = num1;

            }
            else if (num2 > num1 && num2 > num3) {

                highestNumber = num2;

            } else
            {
                highestNumber = num3;
            }

            return highestNumber;
        }
    }
}
