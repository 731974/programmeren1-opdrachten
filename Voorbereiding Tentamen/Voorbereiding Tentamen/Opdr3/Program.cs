namespace Opdr3
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

            string[] strings = new string[20];
            int number = 0;
            string text;

            do
            {

                Console.Write("geef een woord: ");
                text = Console.ReadLine();

                strings[number] = text;

                number++;
            } while (number < 20 && text != "");


            for (int i = 0; i < number; i++)
            {

                if (IsEven(strings[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.WriteLine(strings[i]);

                Console.ResetColor();

            }

            Console.WriteLine("End of programm");

        }

        bool IsEven(string word)
        {

            if (word.Length % 2 == 0)
                return true;

            return false;
        }
    }
}
