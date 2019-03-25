using System.Collections.Generic;
using System.Linq;
using TenPinScoring.Contracts;

namespace TenPinScoring.FrameOutcomes
{
    public class OpenFrame : FrameOutcomeBase, IFrameOutcome
    {
        public string OutcomeName => "Open";

        public int CalculateScore(int index, List<IFrame> frames)
        {
            IFrame currentFrame = frames[index];
            return currentFrame.Turns.Sum(turn => turn.PinsKnocked) + GetPreviousFrameScore(index, frames);
        }
    }
}
