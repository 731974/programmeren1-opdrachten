namespace Assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        // This is public for the tests, don't change this.
        public void Start()
        {

            Console.Write("Enter a day of the week (e.g., Monday): ");
            string input = Console.ReadLine();
            Day day = (Day)Enum.Parse(typeof(Day), input); 
          
            string response = DisplayMessage(day);
            Console.WriteLine(response);

        }

        public string DisplayMessage(Day dayOfWeek)
        {

            switch(dayOfWeek)
            {
                case Day.Monday:
                case Day.Tuesday:
                case Day.Wednesday:
                case Day.Thursday:
                case Day.Friday:
                    return "Weekend is loading...";
                case Day.Saturday:
                case Day.Sunday:
                    return "It's weekend!! Party time!";
                default:
                    return "Something went wrong!";
            }
        }
    }
}
