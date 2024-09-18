namespace Challenge2
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

            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            int reversedOrder = ReversedNumber(number);

            Console.WriteLine($"Reversed number: {reversedOrder}");
        }

        int ReversedNumber(int number)
        {
            int numberLength = number.ToString().Length;
            string reversedOrder = "";
            string reverseableNumber = number.ToString();

            for(int i = 1; i <= numberLength; i++)
            {

                reversedOrder += reverseableNumber[numberLength - i];

            }

            //ERROR: '0' aan het begin of eind van de string wordt verwijderd door int.Parse();
            return int.Parse(reversedOrder);

        }
    }
}
