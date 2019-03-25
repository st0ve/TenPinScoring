using System.Collections.Generic;
using TenPinScoring.Contracts;

namespace TenPinScoring.FrameOutcomes
{
    public abstract class FrameOutcomeBase
    {
        protected int GetPreviousFrameScore(int currentFrameIndex, List<IFrame> frames)
        {
            if (currentFrameIndex == 0) return 0;
            return frames[currentFrameIndex - 1].Score;
        }
    }
}
