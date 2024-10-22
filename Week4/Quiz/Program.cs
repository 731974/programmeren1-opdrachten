namespace Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {

            Console.Write("How many questions should the quiz contain?: ");
            int numberOfQuestion = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Quiz quiz = new(numberOfQuestion);
            Question question;

            for (int i = 0; i < numberOfQuestion; i++) 
            {

                Console.Write($"Enter question number {i + 1}: ");
                string questionText = Console.ReadLine();

                Console.Write("Enter amount of answer options: ");
                int numberOfAnswerOptions = int.Parse(Console.ReadLine());
                string[] answerTextOptions = new string[numberOfAnswerOptions];


                for (int j = 0; j < numberOfAnswerOptions; j++)
                {

                    Console.Write($"Enter answer option number {j + 1}: ");
                    answerTextOptions[j] = Console.ReadLine();

                }

                Console.Write($"Enter the number of the correct answer (1-{numberOfAnswerOptions}): ");
                int CorrectAnswerId = int.Parse(Console.ReadLine());
                Console.WriteLine();

                question = new(questionText, answerTextOptions, CorrectAnswerId);
                quiz.AddQuestion(question);
            }

            quiz.TakeQuiz();
            quiz.DisplayResults();

            Console.WriteLine("End of program");
        }
    }
}
