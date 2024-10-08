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
            Console.Write("Original value: ");
            int originalValue = int.Parse(Console.ReadLine());
            
            ModifyByValue(originalValue);
            Console.WriteLine($"Value after ModifyByValue: {originalValue}");

            ModifyByReference(ref originalValue);
            Console.WriteLine($"Value after ModifyByReference: {originalValue}");
        }

        public void ModifyByValue(int value)
        {
            value = 20;
        }

        public void ModifyByReference(ref int value)
        {
            value = 30;
        }
    }
}
