namespace Assignment7
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

            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            bool isLeapYear = IsLeapYear(year);

            if(isLeapYear)
            {
                Console.WriteLine($"{year} is a leap year");
            } else
            {
                Console.WriteLine($"{year} is not a leap year");
            }
        }

        public bool IsLeapYear(int year)
        {

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    return false;

                }
                return true;
            }

            return false;

        }



    }
}
