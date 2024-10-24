using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    public class Movie
    {

        public string Title;
        public int AvailableTickets;

        public Movie(string title, int availableTickets)
        {
            Title = title;
            AvailableTickets = availableTickets;
        }

        public void BookTickets(int numberOfTickets)
        {
            if (AvailableTickets >= numberOfTickets && numberOfTickets > 0)
            {
                AvailableTickets -= numberOfTickets;
                Console.WriteLine($"You have succesfully booked {numberOfTickets} ticket(s) for {Title}");
            }
            else
                Console.WriteLine("Not enough tickets available, purchase cancelled.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Available Tickets: {AvailableTickets}");
        }
    }
}
