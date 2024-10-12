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

                switch (drinkNumber)
                {
                    case 1:
                        Console.Write($"How much {drinks[0].Name} do you want to order? ");
                        price += CalculatePrice(drinks,  0, int.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.Write($"How much {drinks[1].Name} do you want to order? ");
                        price += CalculatePrice(drinks, 1, int.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.Write($"How much {drinks[2].Name} do you want to order? ");
                        price += CalculatePrice(drinks, 2, int.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        Console.Write($"How much {drinks[3].Name} do you want to order? ");
                        price += CalculatePrice(drinks, 3, int.Parse(Console.ReadLine()));
                        break;
                    default:
                        isNumberZero = true;
                        break;
                }
            }

            Console.WriteLine($"Total price you have to pay: {price:0.00}");

        }


        double CalculatePrice(Drink[] drinks, int choice, int amount)
        {

            return drinks[choice].Price * amount;

        }

        void DisplayDrinks(Drink[] drinks)
        {

            for (int i = 0; i < drinks.Length; i++)
            {
                string getDescription = drinks[i].GetDescription();
                Console.WriteLine($"{i + 1}. {getDescription}");

            }

        }
    }
}
