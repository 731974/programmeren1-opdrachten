﻿namespace Assignment6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {

            Console.Write("Enter a positive integer greater than 1: ");

            int number = int.Parse(Console.ReadLine());

            bool isPrimeNumber = IsPrime(number);

            if(isPrimeNumber)
            {
                Console.WriteLine($"{number} is a prime number.");
            } else
            {
                Console.WriteLine($"{number} is not a prime number.");

            }
        }

        public bool IsPrime(int number)
        {
            int divideCount = 0;

            for (int i = 1; i <= number; i++) { 
            
                if(number % i == 0)
                {
                    divideCount++;
                }

            }

            if(divideCount == 2)
            {
                return true;
            } else
            {
                return false;
            }

        }
    }
}