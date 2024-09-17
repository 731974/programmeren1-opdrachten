namespace Assignment6
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

            Console.Write("Enter your score (0-100): ");
            int score = int.Parse(Console.ReadLine());

            string grade = GetGrade(score);

            if(grade != "I")
            {
                Console.WriteLine($"Your grade is: {grade}");
            }
        }

       public string GetGrade(int score)
        {
            string grade;

            if(score >= 0 && score <= 59)
            {
                grade = "F";
            } else if (score >= 60 && score <= 69)
            {
                grade = "D";
            } else if (score >= 70 && score <= 79)
            {
                grade = "C";
            } else if (score >= 80 && score <= 89)
            {
                grade = "B"; 
            } else if (score >= 90 && score <= 100) {
                grade = "A";
            } else
            {
                Console.WriteLine("Input invalid. Please enter a valid score (0-100).");
                return "I";
            }

            return grade;
        }
    }
}
