namespace Opgave2
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
            bool isNegativeNumberOrZero = false;

            while (!isNegativeNumberOrZero)
            {
                Console.Write("Enter a positive enteger: ");
                int number = int.Parse(Console.ReadLine());

                if(number <= 0)
                {
                    isNegativeNumberOrZero = true;
                    break;
                }

                int countPrimeFactors = CountPrimeFactors(number);

                if (countPrimeFactors == 1)
                {
                    Console.WriteLine($"The number {number} is a prime number!");
                } else
                {
                    Console.WriteLine($"The number {number} has {countPrimeFactors} prime factors.");
                }
            }
            Console.WriteLine("end of program");
        }

        int CountPrimeFactors(int number)
        {
            int diversor = 2;
            int count = 0;

            while (number > 1)
            {
                if (number % diversor == 0)
                {
                    number /= diversor;
                    count++;
                }
                else
                {
                    diversor++;
                }
            }
            return count;
        }
    }
}
