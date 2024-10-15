namespace Opgave4
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
            Drink[] drinks = new Drink[4];
            drinks[0] = new("Rivella", 3.00, false);
            drinks[1] = new("Coca Cola", 4.50, false);
            drinks[2] = new("Bier", 5.50, true);
            drinks[3] = new("Whiskey", 13.00, true);
            
            DisplayDrinks(drinks);

            bool isNumberZero = false;
            double price = 0;

            while (!isNumberZero)
            {
                Console.Write("Select a drink to order: ");
                int drinkNumber = int.Parse(Console.ReadLine());
                int amountOfDrinks;
                string productName;

                if (drinkNumber == 0)
                {
                    isNumberZero = true;
                    break;
                }
                Console.Write($"How much {drinks[drinkNumber-1].Name} do you want to order? ");
                int amount = int.Parse(Console.ReadLine());
                price += amount * drinks[drinkNumber-1].Price;
            }
            Console.WriteLine($"Total price you have to pay: {price:0.00}");
        }

        void DisplayDrinks(Drink[] drinks)
        {
            for (int i = 0; i < drinks.Length; i++)
            {
                Console.WriteLine($"{i+1}. {drinks[i].GetDescription()}");
            }
        }
    }
}
