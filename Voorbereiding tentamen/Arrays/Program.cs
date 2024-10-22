namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        
        Program program = new Program();
        program.Start();

    }

    void Start()
    {

        int[] numbers = { 5, 8, 2, 9, 3, 12, 7 };

        // Stap 2: Array doorlopen en elementen weergeven
        Console.WriteLine("De getallen in de array zijn:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Stap 3: Som van de elementen in de array berekenen
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine("\nDe som van de getallen in de array is: " + sum);

        // Stap 4: Het grootste getal in de array vinden
        int max = numbers[0];  // Begin met het eerste getal
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        Console.WriteLine("Het grootste getal in de array is: " + max);

        // Stap 5: Het kleinste getal in de array vinden
        int min = numbers[0];  // Begin met het eerste getal
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        Console.WriteLine("Het kleinste getal in de array is: " + min);

        // Stap 6: De array omkeren en weergeven
        Console.WriteLine("\nDe omgekeerde array is:");
        Array.Reverse(numbers);
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Stap 7: Het gemiddelde van de getallen berekenen
        double average = (double)sum / numbers.Length;
        Console.WriteLine("\nHet gemiddelde van de getallen is: " + average.ToString("0.00"));

       

    }
}
