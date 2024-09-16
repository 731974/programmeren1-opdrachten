using System.Security.Cryptography;

namespace Assignment7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {

            Console.Write("Enter Dimension size: ");

            int dimensionSize = int.Parse(Console.ReadLine());

            PrintSquare(dimensionSize);

        }

       public void PrintSquare(int dimensionSize)
        {

            for (int i = 1; i <= dimensionSize; i++)
            {
                //Rows
                for (int j = 1; j <= dimensionSize; j++)
                {
                    //Colls
                    if (j >= 2 && i >= 2 && j <= dimensionSize - 1 && i <= dimensionSize - 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("X");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}