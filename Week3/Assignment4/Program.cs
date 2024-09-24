namespace Assignment4
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

            Console.Write("Enter the start of the range: ");
            int startNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the end of the range: ");
            int endNumber = int.Parse(Console.ReadLine());

            (int countEven, int countOdd) countEvenAndOdd = CountEvenAndOdd(startNumber, endNumber);

            Console.WriteLine($"Between {startNumber} and {endNumber}");
            Console.WriteLine($"Even numbers: {countEvenAndOdd.countEven}");
            Console.WriteLine($"Odd numbers: {countEvenAndOdd.countOdd}");

        }


        // This method is returning a tuple.
        // A tuple is a data structure that can hold multiple values of different types.
        // To learn more about tuples, visit: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples
        public (int evenCount, int oddCount) CountEvenAndOdd(int start, int end)
        {
            int evenCount = 0;
            int oddCount = 0;

            for(int i = start; i <= end; i++)
            {

                if (i % 2 == 0)
                {
                    evenCount++;
                } else
                {
                    oddCount++;
                }
            }

            return (evenCount, oddCount);
        }
    }
}