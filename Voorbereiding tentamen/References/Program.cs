namespace References;

class Program
{
    static void Main(string[] args)
    {
    
        Program program = new Program();
        program.Start();

    }

    void Start()
    {
        int v1 = 0;
        int v2 = 2;
        Console.WriteLine($"v1 = {v1} en v2 = {v2}");
        SwapValuesByPassing(v1, v2);
        Console.WriteLine($"v1 = {v1} en v2 = {v2}");
        //Veranderd niets! 
       
        Console.WriteLine();
        Console.WriteLine($"v1 = {v1} en v2 = {v2}");
        SwapValuesByReference(ref v1, ref v2);
        Console.WriteLine($"v1 = {v1} en v2 = {v2}");
        //Nummers zullen veranderen van plek v1 = v2 & v2 = v1;

        int sum, product;
        CalcSumProduct(v1, v2, out sum, out product);
        Console.WriteLine($"product = {product} en sum = {sum}" );

    }

    void CalcSumProduct(int v1, int v2, out int sum, out int product)
    {
        //Nieuwe waardes exporteren
        sum = v1 + v2;
        product = v1 * v2;

    }

    void SwapValuesByPassing (int v1, int v2)
    {
        //Doet dus niets
        int temp = v1;
        v1 = v2;
        v2 = temp;
    }

    void SwapValuesByReference(ref int v1,  ref int v2)
    {
        //Veranderd de waardes
        int temp = v1;
        v1 = v2;
        v2 = temp;
    }
}
