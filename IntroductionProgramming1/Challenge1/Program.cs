namespace Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            age++;
            Console.WriteLine("Next year you will be " + age + " years old.");
        }
    }
}
