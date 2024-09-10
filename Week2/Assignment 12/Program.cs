namespace Assignment_12
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

            Console.Write("Enter the first side: ");
            int firstSide = int.Parse(Console.ReadLine());

            Console.Write("Enter the second side: ");
            int secondSide = int.Parse(Console.ReadLine());

            Console.Write("Enter the third side: ");
            int thirdSide = int.Parse(Console.ReadLine());

            DetermineTriangleType(firstSide, secondSide, thirdSide);

        }

        void DetermineTriangleType(int side1, int side2, int side3)
        {

            //Equilateral

            if (side1 == side2 && side1 == side3 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            //Isosceles
            if ((side1 == side2 && side1 != side3) ||
               (side1 == side3 && side1 != side2) ||
               (side2 == side3 && side2 != side1))
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            //Scalene
            else if (side1 != side2 && side1 != side3 && side2 != side3)
            {
                Console.WriteLine("The triangle is Scalene.");

            }
        }
    }
}
