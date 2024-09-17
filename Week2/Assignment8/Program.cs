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
            Console.Write("Enter a number (1-7) to get the day of the week: ");
            int number = int.Parse(Console.ReadLine());
            string dayName = GetDayOfWeek(number);

            Console.WriteLine($"The day is: {dayName}");
        }

        public string GetDayOfWeek(int dayNumber)
        {
            string dayName = dayNumber switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                7 => "Sunday",
                _ => "Invalid day number"
            };

            return dayName;

        }
    }
}
