namespace Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int answer = 0;
            int randomNumber;
            string anwserExplanation = "";

            for (int i = 1; i < 5; i++) { 
            
                randomNumber = rnd.Next(101, 10000);
                answer += randomNumber;
                Console.WriteLine($"Number{i} = {randomNumber}");
                string formattedExplantion = " " + randomNumber.ToString() + " ";
                anwserExplanation += formattedExplantion;

                //Controleer of er een plus-teken geplaatst moet worden, er komen geen getallen meer na getal 4, dus dan mag het laatste plusteken weggelaten worden.
                if(i <= 3)
                {
                    anwserExplanation += "+";
                }
            }
                
            Console.Write("Wat is het antwoordt van de optelsom?: ");
            string userInput = Console.ReadLine();
            int userAwnser = int.Parse(userInput);

            if (userAwnser == answer)
            {
                Console.WriteLine($"Antwoord is correct, goed gedaan! ({anwserExplanation}= {answer})");
            }
            else
            {
                Console.WriteLine($"Antwoord is helaas niet correct, dit was het goede antwoord {answer} ={anwserExplanation}");

            }

            Console.ReadKey();
        }
    }
}
