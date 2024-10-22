namespace Challenge5
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

            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter empoyee salary: ");
            int salary = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Employee employee = new(name, salary);
            employee.DisplayInfo();
              
           
        }
    }
}
