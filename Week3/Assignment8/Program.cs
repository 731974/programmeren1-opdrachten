namespace Assignment8
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
            Console.Write("Enter the number of elements: ");
            
            int numberOfElements = int.Parse(Console.ReadLine());
            int totalSum = CalculateSum(numberOfElements);
            double average = CalculateAverage(totalSum, numberOfElements);

            Console.WriteLine($"The sum is: {totalSum}");
            Console.WriteLine($"The average is: {average}");
        }

       public double CalculateAverage(int sum, int count)
       {
            return (double)sum / count;
       }

       public int CalculateSum(int count)
       {
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter number {i}: ");
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }

            return sum;
       }
    }
}
