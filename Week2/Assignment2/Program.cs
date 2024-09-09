namespace Assignment2
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

            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            bool isEven = IsEven(number);

            if (isEven) {

                Console.WriteLine($"{number} is an even number.");

            } else
            {
                Console.WriteLine($"{number} is an odd number");
            }

        }

        public bool IsEven(int number)
        {

            if(number % 2 == 0 )
            {
                return true;
            }
            return false;
        }
    }
}
