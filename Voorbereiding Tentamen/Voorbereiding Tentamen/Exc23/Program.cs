namespace Exc23
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

            string text = "FJDKLFJDKLFJDKL";

            string lowercaseText = text.ToLower();

            Console.WriteLine(lowercaseText);

        }
    }
}
