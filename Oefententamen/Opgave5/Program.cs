namespace Opgave5
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

            Console.Write("Enter machine name: ");
            string machineName = Console.ReadLine();

            Console.Write("Enter number of working hours: ");
            int workingHours = int.Parse(Console.ReadLine());

            Machine machine = new(machineName, workingHours);
            machine.DisplayInfo();
        }
        
    }
}
