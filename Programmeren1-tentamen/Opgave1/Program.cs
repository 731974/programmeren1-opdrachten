namespace Opgave1
{
    internal class Program
    {

        /* OPDRACHT
         * 
         * 1) Korting
         * Schrijf een programma dat een korting berekent op basis van het totale aankoopbedrag.
         * 
         * - Schrijf een methode int GetDiscountPercentage(double totalAmount) die de kortingspercentage retourneert voor
         *   het totale aankoopbedrag.
         *   - totale aankoop >= 500 -> korting is 20%
         *   - totale aankoop >= 200 en < 500 -> korting is 10%
         *   - totale aankoop >= 100 en < 200 -> korting is 5%
         *   - totale aankoop < 100 -> geen korting (0%)
         * - In de Start methode vraag de gebruiker om het totale aankoopbedrag in te voeren. Gebruik methode GetDiscountPercentage
         *   om het kortingspercentage te bepalen; print vervolgens het totale aankoopbedrag, de kortingspercentage en het eindbedrag dat
         *   betaald moet worden (na het toepassen van de korting).
         * 
         */


        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Console.Write("Enter the total purchase amount: ");
            double totalAmount = double.Parse(Console.ReadLine());

            double discount = GetDiscountPercentage(totalAmount);

            double newPrice = totalAmount - (((double)discount / 100) * totalAmount);

            Console.WriteLine($"Total Purchase: {totalAmount.ToString("0.00")}");
            Console.WriteLine($"Discount Percentage: {discount}%");
            Console.WriteLine($"Final Amount To Pay: {newPrice.ToString("0.00")}");
        }

        int GetDiscountPercentage(double totalAmount)
        {
            switch (totalAmount)
            {
                case >= 100 and < 200:
                        return 5;
                case >= 200 and < 500:
                    return 10;
                case >= 500:
                    return 20;
                default:
                    return 0;
            }
        }
    }
}
