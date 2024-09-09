namespace Assignment4
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

            Console.Write("Enter the firt number: ");
            double firstNumber = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the second number: ");
            double secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Choose an operation (+, -, *, /): ");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    CalculateResult(firstNumber, secondNumber, operation);
                    break;
                case "-":
                    CalculateResult(firstNumber, secondNumber, operation);
                    break;
                case "*":
                    CalculateResult(firstNumber, secondNumber, operation);
                    break;
                case "/":
                    CalculateResult(firstNumber, secondNumber, operation);
                    break;

            }

        }

        public double CalculateResult(double num1, double num2, string operation)
        {

            double result;

            if (operation == "+")
            {
                result = Add(num1, num2);
            } else if (operation == "-")
            {
                result = Subtract(num1, num2);
            } else if (operation == "/")
            {
                result = Divide(num1, num2);
            } else
            {
                result = Multiply(num1, num2);
            }

            Console.WriteLine($"The result is {result}");

            return result;
        }

        public double Add(double a, double b)
        {

            double result = a + b;

            return result;
        }

        public double Subtract(double a, double b)
        {
            double result = a - b;

            return result;
        }

        public double Multiply(double a, double b)
        {

            double result = a * b;

            return result;

        }

        public double Divide(double a, double b)
        {
            double result = a / b;

            return result;
        }
    }
}
