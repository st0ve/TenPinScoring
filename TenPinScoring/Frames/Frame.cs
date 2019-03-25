using System.Collections.Generic;
using TenPinScoring.FrameOutcomes;

namespace TenPinScoring.Frames
{
    public class Frame : FrameBase
    {
        public Frame() : base(2) { }

        protected override void UpdateFrameOutcome(Queue<int> rolls)
        {
            if(_pinsRemaining == 0)
            {
                if(Turns.Count < _maxTurns)
                {
                    FrameOutcome = new Strike();
                }
                else
                {
                    FrameOutcome = new Spare();
                }
            }
            else
            {
                if(Turns.Count < _maxTurns)
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
