namespace Opdr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
          
            do
            {
                string output = "";
                Console.Write("Geef een getal: ");
                number = int.Parse(Console.ReadLine());



                for (int i = 0; i < number / 2; i++)
                {

                    output += '*';

                }

                int rest = number - (number / 2);

                for (int i = 0; i < rest; i++)
                {

                    output += '!';

                }
                Console.WriteLine(output);
            } while (number > 0);
        }
    }
}
