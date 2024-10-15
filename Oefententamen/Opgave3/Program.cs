namespace Opgave3
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
            int[] numbers = new int[20];

            FillNumbers(numbers);
            int average = GetAverage(numbers);
            DisplayNumbers(numbers, average);
        }

        void DisplayNumbers(int[] numbers, int average)
        {
            Console.WriteLine($"Calculated average number: {average}");
            
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] == average)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (numbers[i] > average)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write($"{numbers[i]} ");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }

        void FillNumbers(int[] numbers)
        {
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 100);
            }
        }
        
        int GetAverage(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) { 
                sum += numbers[i];
            }
            return sum / numbers.Length;
        }
    }
}
