namespace Exc26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new();
            program.Start();
        }

        void Start()
        {
            int sum = 0;
            int ctr = 0;
            int i = 2;

            while (ctr < 500)
            {

                if (isPrime(i))
                {
                    sum += i;
                    ctr++;
                } 
                 i++;
            }

            Console.WriteLine(sum);

        }

        bool isPrime(int n)
        {
            int i = 2;
            while (i < n)
            {
                if (n % i == 0)
                    return false;
                else
                    i++;
            }

            return true;
        }
    }
}
