using System.Collections.Generic;
using NUnit.Framework;
using TenPinScoring.FrameOutcomes;
using TenPinScoring.Frames;

namespace TenPinTests.Tests
{
    [TestFixture]
    public class FrameTests
    {
        [Test]
        public void PlayFrame_OpenFrameRolls_OutcomeWillBeOpenFrame()
        {
            // setup
            Frame frame = new Frame();
            Queue<int> rolls = new Queue<int>(new [] {2, 2});

            // act
            frame.PlayFrame(rolls);

            //assert
            Assert.That(frame.FrameOutcome, Is.TypeOf(typeof(OpenFrame)));
        }

        [Test]
        public void PlayFrame_SpareRolls_OutcomeWillBeSpare()
        {
            // setup
            Frame frame = new Frame();
            Queue<int> rolls = new Queue<int>(new[] { 5, 5 });

            // act
            frame.PlayFrame(rolls);

            //assert
            Assert.That(frame.FrameOutcome, Is.TypeOf(typeof(Spare)));
        }

        [Test]
        public void PlayFrame_StrikeRoll_OutcomeWillBeStrike()
        {
            // setup
            Frame frame = new Frame();
            Queue<int> rolls = new Queue<int>(new[] { 10 });

            // act
            frame.PlayFrame(rolls);

            // assert
            Assert.That(frame.FrameOutcome, Is.TypeOf(typeof(Strike)));
        }

        [Test]
        public void PlayFrame_StrikeRoll_OnlyOneTurnPlayed()
        {
            // setup
            Frame frame = new Frame();
            Queue<int> rolls = new Queue<int>(new[] { 10 });

            // act
            frame.PlayFrame(rolls);

            // assert
            Assert.That(frame.Turns, Has.Count.EqualTo(1));
        }
    }
}
