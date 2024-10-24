namespace Opgave2
{
    internal class Program
    {

        /* OPDRACHT
         * 
         * 2) Perfecte getallen
         * Schrijf een programma dat herhaaldelijk aan de gebruiker vraagt om een positief getal in te voeren en bepaalt
         * of het getal "perfect" is of niet.
         * 
         * - Schrijf een methode bool IsPerfect(int number) die retourneert of een getal perfect is of niet. Een getal is "perfect"
         *   als de som van al zijn delers (behalve het getal zelf) gelijk is aan het getal. Enkele voorbeelden: het getal 6 is
         *   perfect omdat: 6 = 1 + 2 + 3, het getal 8 is niet perfect omdat 8 =/= 1 + 2 + 4.
         *     - Gebruik een loop in de methode om alle getallen van 1.. nummer-1 te verwerken en tel alle delers bij elkaar op.
         * - In de Start methode vraag de gebruiker herhaaldelijk om een positief getal in te voeren; gebruik methode IsPerfect 
         *   om te bepalen of het ingevoerde getal perfect is of niet, en toon het resultaat. Stpo het programma zodr de gebruiker 0
         *   of een negatief getal heeft ingevoerd.
         * 
         */

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            bool numberIsNotNull = false;

            while (!numberIsNotNull)
            {
                Console.Write("Enter a positive enteger: ");
                int positiveEnteger = int.Parse(Console.ReadLine());

                if (positiveEnteger == 0)
                {
                    numberIsNotNull = true;
                    break;
                }

                bool isPerfect = IsPerfect(positiveEnteger);

                if (isPerfect)
                    Console.WriteLine($"The number {positiveEnteger} is a perfect number.");
                else
                    Console.WriteLine($"The number {positiveEnteger} is not a perfect number.");

                Console.WriteLine(); // Whiteline
            }

            Console.WriteLine(); // Whiteline
            Console.WriteLine("end of program");
        }

        bool IsPerfect(int number)
        {
            //Start bij 1, omdat elk getal deelbaar is door 1
            int sum = 1;

            //i start bij 2, omdat delen door 0 niet kan, en delen door 1 altijd kan.
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == number)
                return true;
            
            return false;
        }
    }
}
