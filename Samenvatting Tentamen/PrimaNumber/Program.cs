namespace PrimeNumber;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
        
    }

    void Start()
    {

        Console.Write("Enter a positive enteger: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(number) ? $"{number} is a prime number" : $"{number} is not a prime number");

    }

    bool IsPrime(int number)
    {

        for (int i = 2; i < number; i++)
        {

            if (number % i == 0)
            {
                return false;
            }
            else
                i++;
        }


        return true;
    }
}
