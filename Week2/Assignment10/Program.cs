namespace Assignment10
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

            Console.Write("Enter a letter: ");
            char input = char.Parse(Console.ReadLine());
            char inputFormateted = char.ToLower(input);

            bool isVowel = IsLetterVowel(inputFormateted);
            
            if(isVowel)
            {
                Console.WriteLine($"{input} is a vowel.");
            } else
            {
                Console.WriteLine($"{input} is a consonant.");
            }

        }

        bool IsLetterVowel(char letter)
        {

            switch (letter)
            {

                case 'a':
                    return true;
                case 'e':
                    return true;
                case 'i':
                    return true;
                case 'o':
                    return true;
                case 'u':
                    return true;
                default: 
                    return false;

            }

        }
    }
}
