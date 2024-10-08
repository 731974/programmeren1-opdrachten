namespace Assignment8
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
            Console.Write("Enter deposit amount: ");
            int depositAmount = int.Parse(Console.ReadLine());
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine().ToString();
            Console.Write("Enter withdrawal amount: ");
            int withdrawalAmount = int.Parse(Console.ReadLine());

            BankAccount bankAccount = new(accountNumber, depositAmount);
            bankAccount.Withdraw(withdrawalAmount);
            bankAccount.DisplayInfo();

            BankAccount Piet = new("Piet", 50);
            BankAccount Jan = new("Jan", 6000);

            try
            {
                Piet.Transfer(Jan, 6);
                Piet.DisplayInfo();
                Jan.DisplayInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
