using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class Student
    {
        string Name;
        int[] Grades;

        public Student(string name, int[] grades)
        {
            Grades = grades;
            Name = name;
        }

        public void DisplayGrades()
        {
            Console.WriteLine($"Grades for {Name}: ");

            for (int i = 0; i < Grades.Length; i++)
            {
                if (i < Grades.Length - 1)
                {
                    Console.Write($"{Grades[i]}, ");

                } else
                {
                    Console.Write($"{Grades[i]}\n");
                }
            }

            double averageScore = CalculateAverageGrade();

            Console.WriteLine($"Average Grade: {averageScore}");
        }

        public double CalculateAverageGrade()
        {
            int totalSum = 0;
            foreach (int grade in Grades)
            {

                totalSum += grade;

            }

            return (double)totalSum / Grades.Length;
        }
    }
}
