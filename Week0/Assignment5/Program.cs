﻿namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            int getal1 = rnd.Next(101, 10000);
            int getal2 = rnd.Next(101, 10000);
            int getal3 = rnd.Next(101, 10000);
            int getal4 = rnd.Next(101, 10000);

            int awnser = getal1 + getal2 + getal3 + getal4;
            Console.WriteLine($"Wat is: {getal1} + {getal2} + {getal3} + {getal4}?");

          
            Console.Write("Uw antwoord: "); 
            string userInput = Console.ReadLine();
            int userAwnser = int.Parse(userInput);

            if(userAwnser == awnser)
            {
                Console.WriteLine("Antwoord is correct, goed gedaan!");
            } else
            {
                Console.WriteLine($"Antwoord is helaas niet correct, dit was het goede antwoord {awnser}.");

            }

            Console.ReadKey();
        }
    }
}
