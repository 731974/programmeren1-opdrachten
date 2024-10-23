namespace Opdr1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a word: ");
            string word = Console.ReadLine().ToLower();

            string LettersBackToFront = "";

            for(int i = word.Length - 1; i > 1; i--)
            {

                LettersBackToFront += word[i]; 

            }

            if(LettersBackToFront == word)
            {
                Console.WriteLine($"{word} is a palindroom");
            } else
            {
                Console.WriteLine($"{word} is not a palindroom");
            }
        }
    }
}
