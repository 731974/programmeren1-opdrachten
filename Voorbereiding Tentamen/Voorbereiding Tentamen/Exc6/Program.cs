namespace Exc6
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

            Console.Write("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());
                 
            Console.Write("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 3: ");
            int num3 = int.Parse(Console.ReadLine());

            int result = num1 * num2 * num3;

            Console.WriteLine("The result of {0} x {1} x {2} = {3}", num1, num2, num3, result);
        }

    }
}
