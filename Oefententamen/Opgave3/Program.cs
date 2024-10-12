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
                else if (numbers[i] < average) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.Write($"{numbers[i]} ");

            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

        }

        void FillNumbers(int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {

                Random rnd = new Random();

                numbers[i] = rnd.Next(0, 100);

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
