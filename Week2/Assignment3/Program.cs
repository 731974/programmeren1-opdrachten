namespace Assignment3
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

            CheckNumber(number);
        }

        public void CheckNumber(int number)
        {

            if(number == 0)
            {
                Console.WriteLine("The number is zero.");
            } else
            {
                 if(number < 0)
                {
                    Console.WriteLine("The number is negative.");
                } else
                {
                    Console.WriteLine("The number is positive.");
                }
             }
        }
    }
}
