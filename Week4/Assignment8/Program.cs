using Assignment4;

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
            Console.Write("How many books should there be in the library: ");
            int capacity = int.Parse(Console.ReadLine());

            Library library = new Library(capacity);

            for (int i = 0; i < capacity; i++) {
                //Retrieve user input
                Console.Write("Enter book title: ");
                string bookTitle = Console.ReadLine();

                Console.Write("Enter book author: ");
                string bookAuthor = Console.ReadLine();

                //Display Book Information
                Book book = new Book(bookTitle, bookAuthor);

                library.AddBook(book);
            }

            library.DisplayBooks();
        }
    }
}
