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
            string dayName = "Invalid day number";

            if (dayNumber == 1)
            {
                dayName = "Monday";
            }
            else if (dayNumber == 2)
            {
                dayName = "Tuesday";
            }
            else if (dayNumber == 3)
            {
                dayName = "Wednesday";
            }
            else if (dayNumber == 4) {
                dayName = "Thursday";
            }
            else if (dayNumber == 5)
            {
                dayName = "Friday";
            } else if (dayNumber == 6)
            {
                dayName = "Saturday";
            } else if (dayNumber == 7)
            {
                dayName = "Sunday";
            } 

            return dayName;

        }       
    }
}
