namespace Assignment5
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
            Person[] persons = new Person[3];

            for (int i = 0; i < persons.Length; i++)
            {
                Console.Write($"Enter a name for person {i + 1}: ");
                string name = Console.ReadLine();

                Console.Write($"Enter age for person {i + 1}: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine();

                persons[i] = new Person(name, age);
            }
            PrintPersonArray(persons);
        }

        public void PrintPersonArray(Person[] persons)
        {
            Console.WriteLine("Displaying all persons:");

            for (int i = 0; i < persons.Length; i++) {
                Console.WriteLine($"Person {i + 1}:");
                persons[i].DisplayPersonInfo();
                Console.WriteLine();
            }
        }
    }
}
