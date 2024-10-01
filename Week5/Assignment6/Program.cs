namespace Assignment6
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

            Console.Write("Enter account holder: ");
            string accountHolder = Console.ReadLine();

            Console.Write("Enter deposit amount: ");
            int amount = int.Parse(Console.ReadLine());

            Account account = new(accountHolder);

            account.Deposit(amount);
            account.DisplayAccountInfo();

        }
    }
}
