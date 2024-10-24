namespace Opgave3
{
    internal class Program
    {

        /* OPDRACHT
         * 
         * 3) Voldoendes
         * Schrijf een programma die het aantal voldoendes in een array met cijfers bepaalt
         * 
         * - Schrijf een methode void ReadGrades(int[] grades) die voor elk array element de gebruiker vraagt om een cijfer
         *   in te voeren. Alle ingevoerde cijfers worden in de array opgeslagen.
         * - Schrijf een methode int GetNumberOfPassingGrades(int[] grades, int PassLimit) die het aantal voldoendes in de
         *   array retourneert. (Een cijfer is voldoende als het gelijk is aan of groter is dan de slaaggrens (PassLimit))
         * - In de Start methode vraag de gebruiker om het aantal cijfers in te voeren, maak de array aan en gebruik methode 
         *   ReadGrades om alle cijfers in te lezen en op te slaan. Gebruik methode GetNumberOfPassingGrades om het aantal
         *   voldoendes te bepalen en toon het resultaat.
         * 
         */

        const int PassLimit = 55;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {

            Console.Write("Enter the number of grades: ");
            int numberOfGrades = int.Parse(Console.ReadLine());
            Console.WriteLine(); // Whiteline

            int[] grades = new int[numberOfGrades];

            ReadGrades(grades);

            int getNumberOfPassingGrades = GetNumberOfPassingGrades(grades, PassLimit);

            Console.WriteLine(); // Whiteline
            Console.WriteLine($"The number of passing grades: {getNumberOfPassingGrades}");
        }

        int GetNumberOfPassingGrades(int[] grades, int PassLimit)
        {
            int passingGradeCount = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= PassLimit)
                    passingGradeCount++;
            }
            return passingGradeCount;
        }

        void ReadGrades(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"Enter grade {i + 1}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
