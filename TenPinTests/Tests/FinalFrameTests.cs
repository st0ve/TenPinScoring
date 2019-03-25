using System.Collections.Generic;
using NUnit.Framework;
using TenPinScoring.FrameOutcomes;
using TenPinScoring.Frames;

namespace TenPinTests.Tests
{
    [TestFixture()]
    public class FinalFrameTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(10, 10, 10)]
        [TestCase(5, 5, 0)]
        public void PlayFrame_AnyRolls_OutcomeWillBeOpenFrame(params int[] rollValues)
        {
            // setup
            FinalFrame frame = new FinalFrame();
            Queue<int> rolls = new Queue<int>(rollValues);

            // act
            frame.PlayFrame(rolls);

            //assert
            Assert.That(frame.FrameOutcome, Is.TypeOf(typeof(OpenFrame)));
        }

        [Test]
        public void PlayFrame_SpareRolled_ThreeBallsRolled()
        {
            // setup
            FinalFrame frame = new FinalFrame();
            Queue<int> rolls = new Queue<int>(new []{2, 8, 1});

            // act
            frame.PlayFrame(rolls);

            //assert
            Assert.That(frame.Turns, Has.Count.EqualTo(3));
        }

        [Test]
        public void PlayFrame_FirstRollStrike_ThreeBallsRolled()
        {
            // setup
            FinalFrame frame = new FinalFrame();
            Queue<int> rolls = new Queue<int>(new[] { 10, 0, 0 });

            // act
            frame.PlayFrame(rolls);

            //assert
            Assert.That(frame.Turns, Has.Count.EqualTo(3));
        }

        [Test]
        public void PlayFrame_SecondRollStrike_ThreeBallsRolled()
        {
            // setup
            FinalFrame frame = new FinalFrame();
            Queue<int> rolls = new Queue<int>(new[] { 0, 10, 0 });

            // act
            frame.PlayFrame(rolls);

            //assert
            Assert.That(frame.Turns, Has.Count.EqualTo(3));
        }

        [Test]
        public void PlayFrame_OpenFrameRolled_TwoBallsRolled()
        {
            // setup
            FinalFrame frame = new FinalFrame();
            Queue<int> rolls = new Queue<int>(new[] { 0, 1, 10 });

            // act
            frame.PlayFrame(rolls);

            //assert
            Assert.That(frame.Turns, Has.Count.EqualTo(2));
        }
    }
}
