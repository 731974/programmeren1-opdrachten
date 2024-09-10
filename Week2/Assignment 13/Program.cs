namespace Assignment_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            program.Start();

        }
        void Start()
        {

            Console.Write("Enter your balance: ");
            int balance = int.Parse(Console.ReadLine());

            Console.Write("Enter the amount to withdraw: ");
            int amount = int.Parse(Console.ReadLine());

            if(amount % 10 != 0) 
            {
                Console.WriteLine("Enter a correct amount, only tens are allowed.");

                return;
            }

            bool isValidWithdrawal = IsValidWithdrawal(balance, amount);

            if (isValidWithdrawal) {

                Console.WriteLine(@$"Withdrawal succesfull 
New balance: {balance - amount}");
            } else
            {
                Console.WriteLine(@$"Withdrawal unsuccesfull.");
            }
        }

        public bool IsValidWithdrawal(int balance, int amount)
        {

            if (balance >= amount)
            {
                return true;
            }

            return false;

        }
    }
}
