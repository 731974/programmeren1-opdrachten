namespace Opdr5
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

            Console.Write("Enter amount of kilometers:");
            int kilometers = int.Parse(Console.ReadLine());

            Console.Write("Enter amount of time (in minuten): ");
            double time = double.Parse(Console.ReadLine());

            Console.WriteLine($"Je snelheid is {CalculatePace(kilometers, time).ToString("0.00")} km/h");

        }

        double CalculatePace(int  kilometers, double time)
        {

            return (double)kilometers / (time / 60);

        }
    }
}
