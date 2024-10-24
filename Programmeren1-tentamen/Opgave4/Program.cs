namespace Opgave4
{
    internal class Program
    {

        /* OPDRACHT
         * 
         * 4) Films
         * Schrijf een programma voor het beheren van filmkaartjes. Met het programma kunnen gebruikers de beschikbare films zien
         * en kaartjes hiervoor reserveren.
         * 
         * - Maak een Movie class met public velden string Title en int AvaiableTickets.
         * - Geef class Movie een constructor die alle velden initaliseert: public Movie(stirng title, int availableTickets)
         * - (in class Movie) Schrijf een methode void BookTickets(int numberOfTickets) die het aantal beschikbare kaartjes
         *   verlaagt als er genoeg kaartjes beschikbaar zijn.
         * - (in class Program) Schrijf een methode void DisplayMovies(Movie[] movies) die alle films in de gegeven array toont
         * - in de Start methode maak 3 (hard coded) films aan en plaats deze in een array met Movie objecten
         * - Gebruik methode DisplayMovies om de details van alle films te tonen
         * - Vraag de gebruiker om een film te selecteren en het aantal te reserveren kaartjes in te voeren
         * - Gebruik methode BookTickets om de kaartjes te reserveren voor de geselecteerde film.
         * - Gebruik nogmaals methode DisplayMovies om de verschillen te zien in het aantal beschikbare kaartjes.
         * 
         */

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {

            Movie[] movies = new Movie[3];
            movies[0] = new("Epic", 20);
            movies[1] = new("1917", 40);
            movies[2] = new("De slag om de Schelde", 30);

            DisplayMovies(movies);

            Console.Write("Select a movie number to book tickets (1-3): ");
            int numberSelectNumber = int.Parse(Console.ReadLine()) - 1; 
           
            Console.Write($"How many tickets would you like to book for {movies[numberSelectNumber].Title}? ");
            int amountOfTickets = int.Parse(Console.ReadLine());
            
            movies[numberSelectNumber].BookTickets(amountOfTickets);

            Console.WriteLine(); //Whiteline
            DisplayMovies(movies);
        }

        void DisplayMovies(Movie[] movies)
        {
            Console.WriteLine("Available Movies:");
            for (int i = 0; i < movies.Length; i++)
            {
                Console.Write($"{i+1}. ");
                movies[i].DisplayInfo();
            }
            Console.WriteLine(); //Whiteline
        }
    }
}
