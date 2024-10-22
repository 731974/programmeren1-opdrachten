namespace Challenge4
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

            Console.Write("Enter item name: ");
            string itemName = Console.ReadLine();

            Console.Write("Enter quantity: ");
            int itemQuantity = int.Parse(Console.ReadLine());

            Console.Write("Enter unit price: ");
            double itemPrice = double.Parse(Console.ReadLine());

            Invoice invoice = new Invoice(itemName, itemQuantity, itemPrice);
            invoice.DisplayInfo();
            
        }
    }
}
