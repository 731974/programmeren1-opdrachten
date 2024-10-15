namespace Opgave1
{
    internal class Program
    {
        const int MinutesInHour = 60;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Console.Write("Enter the running distance (in kilometers): ");
            double distance = double.Parse(Console.ReadLine());
            Console.Write("Enter the time taken (in minutes): ");
            int time = int.Parse(Console.ReadLine());
            Console.Write("Do you want to calculate pace (min/km) or speed (km/hr)? ");
            string input = Console.ReadLine();

            CalculateAndPrintResult(input, distance, time);
        }

        void CalculateAndPrintResult(string input, double distance, int time) {
            if (input == "pace")
            {
                double pace = GetPace(distance, time);
                Console.WriteLine($"Your pace is {pace:0.00} min/km");
                return;
            } 
            else if (input == "speed")
            {
                double speed = GetSpeed(distance, time);
                Console.WriteLine($"Your speed is {speed:0.00} km/hr");
                return;
            } 
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }

        double GetPace(double distance, int time)
        {
            return time / distance;
        }

        double GetSpeed(double distance, int time)
        {
            return (double)distance / time * MinutesInHour;
        }
    }
}
