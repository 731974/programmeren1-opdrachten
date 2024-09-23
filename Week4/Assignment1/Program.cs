namespace Assignment1
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

            //Retrieving user input from the console
            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Enter height: ");
            double height = double.Parse(Console.ReadLine());

            //Creating new Class
            Rectangle area = new Rectangle();

            //Constructor for new Class
            area.Width = width;
            area.Height = height;

            //Using the functions inside the new Class
            double perimeterOfRectangle = area.CalculatePerimeter();
            double areaOfRectangle = area.CalculateArea();

            //Printing out the result
            Console.WriteLine($"Area: {areaOfRectangle}");
            Console.WriteLine($"Perimeter: {perimeterOfRectangle}");

        }
    }
}
