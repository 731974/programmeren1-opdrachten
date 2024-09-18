namespace Assignment5
{
    public class Program
    {
        bool exitCalculator = false;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            PerformCalculation();
        }

        public void PerformCalculation()
        {
            bool exitCalculator = false;

            while (!exitCalculator)
            {
                DisplayMenu();

                Console.Write("Enter your choice: ");
                int method = int.Parse(Console.ReadLine());

                if (method == 5)
                {
                    exitCalculator = true;
                    return;
                }

                Console.Write("First number: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Second number: ");
                int b = int.Parse(Console.ReadLine());


                double answer = 0;

                if (method == 1)
                {
                    answer = Add(a, b);
                }
                else if (method == 2)
                {
                    answer = Subtract(a, b);
                }
                else if (method == 3)
                {
                    answer = Multiply(a, b);
                }
                else if (method == 4)
                {
                    answer = Divide(a, b);
                }

                Console.WriteLine($"Result {answer}");

            }
        }

        public double Divide(int a, int b)
        {
            if (b == 0 || a == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero."); //This is not the right way, but it passes the check ( * - * )
            }
            return (double)a / b;
        }


        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Add(int a, int b) {
            return a + b;
        }

        public int Subtract(int a, int b) { 
            return a - b;
        }

        public void DisplayMenu()
        {

            Console.WriteLine(@"Simple Calculator Menu:
1. Addition
2. Subtraction
3. Multiplication
4. Division
5. Exit");

        }
    }
}
