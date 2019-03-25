using System.Collections.Generic;
using NUnit.Framework;
using TenPinScoring.Contracts;
using TenPinScoring.FrameOutcomes;
using TenPinScoringTests.Mocks;

namespace TenPinScoringTests.Tests.FrameOutcomes
{
    [TestFixture]
    public class OpenFrameTests
    {
        [Test]
        public void CalculateScore_SingleFrameInGame_ScoreTalliedForOneFrame()
        {
            // setup
            IFrameOutcome outcome = new OpenFrame();
            List<IFrame> frames = new List<IFrame>()
            {
                new MockFrame()
                {
                    Turns = new List<ITurn>()
                    {
                        new MockTurn() {PinsKnocked = 3},
                        new MockTurn() {PinsKnocked = 4}
                    }
                }
            };

            // act
            int score = outcome.CalculateScore(0, frames);

            // assert
            Assert.That(score, Is.EqualTo(7));
        }
    }
}
