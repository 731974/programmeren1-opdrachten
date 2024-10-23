namespace ForLoop;

class Program
{
    static void Main(string[] args)
    {
    
        Program program = new Program();
        program.Start();    
    }

    void Start()
    {

        //repeat <statements> fixed number of times

        // Een for loop gebruiken we vooral in combinatie met arrays aangezien we daar een vast aantal iteraties doorgaan. 
        // Doorgaande vuistregel is: als we weten hoeveel iteraties, dan For loop anders een van de twee While loops.

        // Een for loopt begint altijd bij 0, en eindigt daarom ook 1 voor de lengte. 
        // Lengte is 3 \/, maar 0 1 2, betekend dus 3 - 1, oftewel tot aan 3. Het 3e vakje doet dus niet mee.
        int[] ints = [1, 2, 3];

        for (int i = 0; i < ints.Length; i++)
        {

            Console.WriteLine(ints[i]);
        }
    }
}
