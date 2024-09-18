namespace Challenge4
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

            Console.Write("Enter a string: ");
            string input = Console.ReadLine().ToLower().Replace(" ", "");
            
            Console.WriteLine(input);

            bool isPalindrome = IsPalindrome(input);

            if(isPalindrome)
            {
                Console.WriteLine($"'{input}' is a palindrome.");
            } else
            {
                Console.WriteLine($"'{input}' is not a palindrome.");
            }
        }

        bool IsPalindrome(string input)
        {
            int inputLength = input.Length;

            for (int i = 0; i < inputLength / 2; i++)
            {
                if (input[i] != input[inputLength - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
