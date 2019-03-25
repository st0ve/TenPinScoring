using System.Collections.Generic;
using System.Linq;
using TenPinScoring.Contracts;

namespace TenPinScoring.FrameOutcomes
{
    public class Spare : FrameOutcomeBase, IFrameOutcome
    {
        public string OutcomeName => "Spare";

        public int CalculateScore(int index, List<IFrame> frames)
        {
            IFrame currentFrame = frames[index];
            return currentFrame.Turns.Sum(turn => turn.PinsKnocked) + frames[index + 1].Turns[0].PinsKnocked +
                   GetPreviousFrameScore(index, frames);
        }
    }
}
