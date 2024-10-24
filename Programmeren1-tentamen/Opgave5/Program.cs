namespace Opgave5
{
    internal class Program
    {

        /* OPDRACHT
         * 
         * 5) Curcussen
         * - Maak een Course class met een readonly property string CourseName
         * - Geef class Course een read/write property int AssignmentScore en een read/write property int ExamScore
         * - Geef class Course een constructor die alle properties initialiseert: public Course(string courseName, int assignmentScore, int examScore)
         * - Geef class Course een calculated property int FinalGrade die het gemiddelde van de assignment score en de exam score retourneert
         * - (in class Course) Schrijf een method void DisplayCourse() die de details van een cursus toont
         * - (in class Program) Schrijf een methode Course ReadCourse() die de details van een cursus toont.
         * - In de Start methode maak een Course object aan (via methode ReadCourse) en toon de details van deze course (via object methode DisplayCourse)
         * 
         */

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Course course = ReadCourse();
            course.DisplayCourse();
        }

        Course ReadCourse()
        {
            Console.Write("Enter course name: ");
            string courseName = Console.ReadLine();

            Console.Write("Enter assignment score (0...100): ");
            int assignmentScore = int.Parse(Console.ReadLine());

            Console.Write("Enter exam score (0...100): ");
            int examScore = int.Parse(Console.ReadLine());

            return new(courseName, assignmentScore, examScore);
        }
    }
}
