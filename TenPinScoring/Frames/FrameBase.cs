using System.Collections.Generic;
using TenPinScoring.Contracts;
using TenPinScoring.Entities;

namespace TenPinScoring.Frames
{
    public abstract class FrameBase : IFrame
    {
        protected readonly int _maxTurns;
        protected int _turnsPlayed;
        protected int _pinsRemaining = 10;

        public int Score { get; set; }
        public IFrameOutcome FrameOutcome { get; protected set; }
        public List<Turn> Turns { get; private set; }

        protected FrameBase(int maxTurns)
        {
            _maxTurns = maxTurns;
            Turns = new List<Turn>();
        }

        public virtual void PlayFrame(Queue<int> rolls)
        {
            Turn turn = new Turn
            {
                PinsKnocked = rolls.Dequeue()
            };
            Turns.Add(turn);
            _turnsPlayed++;
            _pinsRemaining -= turn.PinsKnocked;

             UpdateFrameOutcome(rolls);
        }

        protected abstract void UpdateFrameOutcome(Queue<int> rolls);
    }
}
