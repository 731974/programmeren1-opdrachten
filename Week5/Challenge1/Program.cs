namespace Challenge1
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

            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Enter height: ");
            double height = double.Parse(Console.ReadLine()); 

            Rectangle rectangle = new(width, height);
            rectangle.DisplayInfo();

           

        }
    }
}
