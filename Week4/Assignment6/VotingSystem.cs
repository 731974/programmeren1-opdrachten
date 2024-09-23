using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class VotingSystem
    {

       public VoteOption[] votes;
       public int currentVoteIndex = 0;
       public int maxVotes;

        public VotingSystem(int size)
        {
            votes = new VoteOption[size];
            maxVotes = size;
        }

      public void CastVote(VoteOption vote)
        {
            if (currentVoteIndex < maxVotes)
            {
                votes[currentVoteIndex] = vote;
                currentVoteIndex++;
            }
            else
            {
                Console.WriteLine("All votes have been cast.");
            }
        

        }
        public void DisplayResults()
        {
           int yesVotes = 0, noVotes = 0;

            for (int i = 0; i < votes.Length; i++)
            {

                if (votes[i] == VoteOption.Yes) {
                    yesVotes++;
                } else
                {
                    noVotes++;
                }

            }

            Console.WriteLine("Results:");
            Console.WriteLine($"Yes: {yesVotes}");
            Console.WriteLine($"No: {noVotes}");

        }
    }
}
