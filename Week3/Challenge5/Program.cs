using System.Security.Cryptography;

namespace Challenge5
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
            int randomNumber = GenerateRandomNumber();
            bool correctGuess = false;
            int attempts = 0;

            while(!correctGuess)
            {
                attempts++;

                Console.Write("Guess a number between 1 and 100: ");
                int inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber == randomNumber)
                {
                    correctGuess = true;
                } else
                {
                    if (inputNumber > randomNumber)
                    {
                        Console.WriteLine("Too high. Try again.");
                    } else
                    {
                        Console.WriteLine("Too low. Try again.");
                    }
                }
            }

            Console.WriteLine($"Congratulations! You guessed the correct number in {attempts} attempts.");
        }

        int GenerateRandomNumber()
        {
            Random rdm = new Random();
            return rdm.Next(1,101);
        }
    }
}
