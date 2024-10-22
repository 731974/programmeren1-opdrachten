using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    public class Question
    {
        public string questionText;
        public string[] options;
        public int correctAnswerIndex;

       public Question(string questionText, string[] options, int correctAnswerIndex)
        {
            this.questionText = questionText;
            this.options = options;
            this.correctAnswerIndex = correctAnswerIndex;
        }
    }
}
