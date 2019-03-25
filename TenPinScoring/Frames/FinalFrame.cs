using System.Collections.Generic;
using TenPinScoring.FrameOutcomes;

namespace TenPinScoring.Frames
{
    public class FinalFrame : FrameBase
    {
        public FinalFrame() : base(3) { }

        protected override void UpdateFrameOutcome(Queue<int> rolls)
        {
            if (_pinsRemaining <= 0)
            {
                if (Turns.Count < _maxTurns)
                {
                    PlayFrame(rolls);
                }
                else
                {
                    FrameOutcome = new OpenFrame();
                }
            }
            else
            {
                if (Turns.Count == 1)
                {
                    PlayFrame(rolls);
                }
                else
                {
                    FrameOutcome = new OpenFrame();
                }
            }
        }
    }
}
