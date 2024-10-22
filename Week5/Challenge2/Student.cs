using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    public class Student
    {
        private int[] _scores;
        public int[] Scores
        {
            get
            {
                return _scores;
            }
            set {
                _scores = value;
            }
        }

        double AverageScore
        {
            get
            {
                int sum = 0;
                foreach (int num in _scores) { 
                    sum += num;
                }

                return (double)sum / _scores.Length;
            }
        }

        public Student(int[] scores)
        {
            Scores = scores;
        }

        public void DisplayInfo()
        {

            Console.WriteLine("Student Details: ");
            Console.WriteLine($"Average Score: {AverageScore:F2}");

        }

    }
}
