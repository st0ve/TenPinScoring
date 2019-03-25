using System.Collections.Generic;
using System.Linq;
using TenPinScoring.Contracts;

namespace TenPinScoring.FrameOutcomes
{
    public class Strike : FrameOutcomeBase, IFrameOutcome
    {
        public string OutcomeName => "Strike";

        public int CalculateScore(int index, List<IFrame> frames)
        {
            IFrame currentFrame = frames[index];
            IFrame secondFrame = frames[index+1];
            int previousScore = GetPreviousFrameScore(index, frames);
            if(secondFrame.Turns.Count > 1)
            {

                return currentFrame.Turns.Sum(turn => turn.PinsKnocked) +
                       secondFrame.Turns[0].PinsKnocked +
                       secondFrame.Turns[1].PinsKnocked +
                       previousScore;
            }

            IFrame thirdFrame = frames[index+2];
            return currentFrame.Turns.Sum(turn => turn.PinsKnocked) +
                   secondFrame.Turns[0].PinsKnocked +
                   thirdFrame.Turns[0].PinsKnocked + previousScore;

        }
    }
}
