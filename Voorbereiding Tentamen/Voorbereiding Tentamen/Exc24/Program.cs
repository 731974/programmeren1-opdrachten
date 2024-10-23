namespace Exc24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program program = new();
            program.Start();

        }

        void Start()
        {

            string text = "Write a C# Sharp Program to display the following pattern using the alphabet.";

            string[] words = text.Split(' ');

            int largestWord = 0;
            string word = "";

            foreach (string ch in words)
            {

                if (ch.Length > largestWord)
                {
                    largestWord = ch.Length;
                    word = ch;
                }

            }

            Console.WriteLine(word);

        }
    }
}
