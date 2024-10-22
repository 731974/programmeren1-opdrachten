using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    public class Quiz
    {
        Question[] quizQuestions;
        int[] quizAnswers;
        int currentQuizIndex = 0;

        public Quiz(int numberOfQuestions) {
       
            quizQuestions = new Question[numberOfQuestions];
            quizAnswers = new int[numberOfQuestions];
        }

        public void AddQuestion(Question question)
        {
            if (currentQuizIndex < quizQuestions.Length) {
                quizQuestions[currentQuizIndex] = question;
                currentQuizIndex++;
            } else
                throw new Exception("Out of bound!");
        }

        public void TakeQuiz()
        {

            for (int i = 0; i < quizQuestions.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}: {quizQuestions[i].questionText}");

                for (int j = 0; j < quizQuestions[i].options.Length; j++) {
                    Console.WriteLine($"{j + 1}: {quizQuestions[i].options[j]}");
                }

                Console.Write($"Enter your answer (1-{quizQuestions[i].options.Length}): ");
                int inputAnswer = int.Parse(Console.ReadLine());
                Console.WriteLine();
                quizAnswers[i] = inputAnswer;
               
            }    
        }

        public void DisplayResults()
        {
            int score = 0;

            for (int i = 0; i < quizAnswers.Length; i++)
            {
                int quizAnswer = quizQuestions[i].correctAnswerIndex;
                int userAnswer = quizAnswers[i];

                if (quizAnswer == userAnswer)
                {
                    score++;
                }
            }
            Console.WriteLine($"Your score: {score}/{quizAnswers.Length}");
        }
    }
}
