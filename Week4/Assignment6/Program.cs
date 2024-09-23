namespace Assignment6
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

            Console.Write("How many votes should be processed: ");
            int sizeOfArray = int.Parse(Console.ReadLine());

            VotingSystem voteSystem = new VotingSystem(sizeOfArray);

            for (int i = 0; i < sizeOfArray; i++) {


                Console.Write("Enter your vote (Yes/No): ");
                VoteOption vote = (VoteOption)Enum.Parse(typeof(VoteOption), Console.ReadLine());

                voteSystem.CastVote(vote);
            }

            voteSystem.DisplayResults();
        }
    }
}
