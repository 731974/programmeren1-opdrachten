using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave5
{
    public class Course
    {

        public string CourseName { get; }

        public int AssignmentScore { get; set; }
        public int ExamScore { get; set; }

        public int FinalGrade
        {
            get
            {
                return (AssignmentScore + ExamScore) / 2;
            }
        }

        public Course(string courseName, int assignmentScore, int examScore)
        {
            CourseName = courseName;
            AssignmentScore = assignmentScore;
            ExamScore = examScore;
        }

        public void DisplayCourse()
        {
            Console.WriteLine(); //Whiteline
            Console.WriteLine($"Course: {CourseName}");
            Console.WriteLine($"Assignment Score: {AssignmentScore}");
            Console.WriteLine($"Exam Score: {ExamScore}");
            Console.WriteLine($"Final Grade: {FinalGrade}");

        }
    }
}
