// VotingSystemTests.cs
using NUnit.Framework;
using System;
using System.IO;

namespace Assignment6.Tests
{
    [TestFixture]
    public class VotingSystemTests
    {
        [Test]
        public void Constructor_ValidSize_InitializesVotesArray()
        {
            // Arrange
            int size = 5;

            // Act
            var votingSystem = new VotingSystem(size);

            // Assert
            Assert.AreEqual(size, votingSystem.votes.Length);
            Assert.AreEqual(0, votingSystem.currentVoteIndex);
        }

        [Test]
        public void CastVote_ValidVote_AddsVoteToArray()
        {
            // Arrange
            var votingSystem = new VotingSystem(3);

            // Act
            votingSystem.CastVote(VoteOption.Yes);
            votingSystem.CastVote(VoteOption.No);

            // Assert
            Assert.AreEqual(VoteOption.Yes, votingSystem.votes[0]);
            Assert.AreEqual(VoteOption.No, votingSystem.votes[1]);
            Assert.AreEqual(2, votingSystem.currentVoteIndex);
        }

        [Test]
        public void CastVote_ExceedsArraySize_DisplaysMessage()
        {
            // Arrange
            var votingSystem = new VotingSystem(1);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            votingSystem.CastVote(VoteOption.Yes);
            votingSystem.CastVote(VoteOption.No);

            // Assert
            var output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("All votes have been cast."));
        }

        [Test]
        public void DisplayResults_ValidVotes_DisplaysCorrectCounts()
        {
            // Arrange
            var votingSystem = new VotingSystem(3);
            votingSystem.CastVote(VoteOption.Yes);
            votingSystem.CastVote(VoteOption.No);
            votingSystem.CastVote(VoteOption.Yes);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            votingSystem.DisplayResults();

            // Assert
            var output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Yes: 2"));
            Assert.IsTrue(output.Contains("No: 1"));
        }
    }
}

