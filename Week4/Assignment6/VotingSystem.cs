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

        public VotingSystem(int size)
        {
            votes = new VoteOption[size];
        }

        public void CastVote(VoteOption vote)
        {
            if (currentVoteIndex < votes.Length)
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
            int yesCount = 0, noCount = 0;

            for (int i = 0; i < votes.Length; i++)
            {
                if (votes[i] == VoteOption.Yes) 
                {
                    yesCount++;
                } 
                else
                {
                    noCount++;
                }
            }

            Console.WriteLine("Results:");
            Console.WriteLine($"Yes: {yesCount}");
            Console.WriteLine($"No: {noCount}");
        }
    }
}
