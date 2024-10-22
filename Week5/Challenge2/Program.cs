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

            Console.Write("Enter scores separated by spaces: ");
            int[] grades = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Student student = new(grades);

            student.DisplayInfo();
                

        }
    }
}
