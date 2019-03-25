using System.Collections.Generic;
using NUnit.Framework;
using TenPinScoring;
using TenPinScoring.Entities;

namespace TenPinTests.Tests
{
    [TestFixture]
    public class GameTests
    {
        [TestCase(300, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10)] // all strike
        [TestCase(150, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5)] // all spare
        [TestCase(20, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)] // all open
        [TestCase(95, 5, 5, 6, 1, 2, 2, 3, 3, 8, 0, 10, 2, 7, 3, 7, 3, 0, 6, 4, 0)]
        [TestCase(67, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 10, 10, 1, 1, 0, 0, 0, 0)]
        public void Play_ValidRollInputs_FinalScoreIsCorrect(int finalScore, params int[] rollValues)
        {
            // setup
            Game game = new Game();
            game.SetupGame(10);
            Queue<int> rolls = new Queue<int>(rollValues);

            // act
            GameResult result = game.Play(rolls);

            // assert
            Assert.That(result.FinalScore, Is.EqualTo(finalScore));
        }
    }
}
