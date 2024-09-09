namespace Assignment1
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

            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());
            bool isAdult = IsAdult(age);

            if(isAdult)
            {
                Console.WriteLine("You're an adult.");
            } else
            {
                Console.WriteLine("You're an minor");
            }

        }

        public bool IsAdult(int age)
        {

               if(age >= 18)
            {
                return true;
            } 

            return false;
        }
    }
}
