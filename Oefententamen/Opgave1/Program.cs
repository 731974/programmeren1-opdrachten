namespace Opgave1
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

            Console.Write("Enter the running distance (in kilometers): ");
            double distance = double.Parse(Console.ReadLine());

            Console.Write("Enter the time taken (in minutes): ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Do you want to calculate pace (min/km) or speed (km/hr)? ");
            string input = Console.ReadLine();

            GetResult(input, distance, time);
        }

        void GetResult(string input, double distance, int time) {

            switch (input)
            {

                case "pace":
                    double pace = GetPace(distance, time);
                    Console.WriteLine($"Your pace is {pace:0.00} min/km");
                    break;
                case "speed":
                    double speed = GetSpeed(distance, time);
                    Console.WriteLine($"Your speed is {speed:0.00} km/hr");
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }

      

        double GetPace(double distance, int time)
        {
            return time / distance;
        }

        double GetSpeed(double distance, int time)
        {
            return (double)distance / time * 60;
        }
    }
}
