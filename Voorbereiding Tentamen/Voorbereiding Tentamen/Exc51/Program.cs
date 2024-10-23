namespace Exc51
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

            Console.Write("Enter an amount of days: ");
            int days = int.Parse(Console.ReadLine());

            int years = days / 365;
            int weeks = (days % 365) / 7;
            days -= years * 365 + weeks * 7;
            Console.WriteLine("jaar: {0} weken: {1} dagen: {2}", years, weeks, days);


          

        }
    }
}
