namespace Opdr4
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

            Random rnd = new Random();
            bool randomNumberIsZero = false;

            while (!randomNumberIsZero)
            {
                int randomNumber = rnd.Next(0, 11);

                if (randomNumber == 0)
                {
                    randomNumberIsZero = true;
                    break;
                }

                Console.WriteLine($"Faculteit van {randomNumber} is {Faculteit(randomNumber)}");



            }

            Console.WriteLine("einde programma");

        }

        int Faculteit(int getal)
        {
            int sum = 1;
            for (int i = 2; i < getal; i++)
            {

                sum *= i;

            }

            return sum;
        }
    }
}
