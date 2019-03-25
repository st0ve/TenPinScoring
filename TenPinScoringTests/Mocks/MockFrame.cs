using System.Collections.Generic;
using TenPinScoring.Contracts;

namespace TenPinScoringTests.Mocks
{
    internal class MockFrame : IFrame
    {
        public int Score { get; set; }
        public IFrameOutcome FrameOutcome { get; set; }
        public List<ITurn> Turns { get; set; }

        public void PlayFrame()
        {
            throw new System.NotImplementedException();
        }
    }
}
