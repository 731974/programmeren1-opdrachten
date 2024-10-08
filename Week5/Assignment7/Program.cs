namespace Assignment7
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
            Console.Write("Enter product name: ");
            string productName = Console.ReadLine();
            Console.Write("Enter product price: ");
            double productPrice = int.Parse(Console.ReadLine());

            Product product = new(productPrice, productName);
            product.DisplayProductInfo();
        }
    }
}
