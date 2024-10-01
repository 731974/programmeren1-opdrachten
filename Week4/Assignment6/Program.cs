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
            int voteCount = int.Parse(Console.ReadLine());

            VotingSystem votingSystem = new(voteCount);

            for (int i = 0; i < votingSystem.votes.Length; i++) {
                Console.Write("Enter your vote (Yes/No): ");
                votingSystem.CastVote((VoteOption)Enum.Parse(typeof(VoteOption), Console.ReadLine()));
            }

            votingSystem.DisplayResults();
        }
    }
}
