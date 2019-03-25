using System.Collections.Generic;
using TenPinScoring.FrameOutcomes;

namespace TenPinScoring.Frames
{
    internal class FinalFrame : FrameBase
    {
        public FinalFrame(int maxTurns) : base(maxTurns) { }

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
