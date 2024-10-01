namespace Assignment3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        // This is public for the tests, don't change this.
        public void Start()
        {
            int[] numbers = new int[3];

            Console.WriteLine("Enter 3 integers: ");

            for (int i = 0; i < numbers.Length; i++) {
                Console.Write($"Enter number {i}: ");
                numbers[i] = int.Parse(Console.ReadLine());

            }

            int totalSum = CalculateSum(numbers);
            double average = CalculateAverage(numbers);

            Console.WriteLine($"Sum: {totalSum}");
            Console.WriteLine($"Average: {average:0.00}");
        }

        public double CalculateAverage(int[] numbers)
        {
            double totalSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                totalSum += numbers[i];
            }

            return (double)totalSum / numbers.Length;
        }

        public int CalculateSum(int[] numbers)
        {
           int totalSum = 0;

           for (int i = 0; i < numbers.Length; i++)
           {
                totalSum += numbers[i];
           }

            return totalSum;
        }
    }
}
