namespace Assignment2
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

            Console.Write("Enter book title: ");
            string bookName = Console.ReadLine();

            Console.Write("Enter book author: ");
            string bookAuthor = Console.ReadLine(); 

            Book book = new(bookName, bookAuthor);

            book.DisplayBookInfo();
        }
    }
}
