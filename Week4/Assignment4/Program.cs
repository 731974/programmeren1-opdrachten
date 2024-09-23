namespace Assignment4
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

            //Retrieve user input
            Console.Write("Enter book title: ");
            string bookTitle = Console.ReadLine();

            Console.Write("Enter book author: ");
            string bookAuthor = Console.ReadLine();

            //Display Book Information
            Book book = new Book(bookTitle, bookAuthor);
            book.DisplayBookInfo();
        }
    }
}
