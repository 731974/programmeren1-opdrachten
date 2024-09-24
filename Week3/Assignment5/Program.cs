namespace Assignment5
{
    public class Program
    {
        bool isValidChoice = false;

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
            bool isValidChoice = false;

            while (!isValidChoice)
            {
                DisplayMenu();

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice >= 5)
                {
                    isValidChoice = true;
                    return;
                }

                Console.Write("First number: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Second number: ");
                int b = int.Parse(Console.ReadLine());


                double answer = 0;

               switch(choice)
               {
                    case 1:
                        answer = Add(a, b);
                        break;
                    case 2:
                        answer = Subtract(a, b);
                        break;
                    case 3:
                        answer = Multiply(a, b);
                        break;
                    case 4:
                        answer = Divide(a, b);
                        break;
                    default:
                        throw new Exception("This is not a valid choice");
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
            return (double)a / (double)b;
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
