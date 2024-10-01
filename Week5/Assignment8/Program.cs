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

            BankAccount bankAccount = new(accountNumber, depositAmount);

            Console.Write("Enter withdrawal amount: ");
            int withdrawalAmount = int.Parse(Console.ReadLine());

            bankAccount.Withdraw(withdrawalAmount);

            bankAccount.DisplayInfo();

        }
    }
}
