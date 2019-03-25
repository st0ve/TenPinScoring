using System.Collections.Generic;
using System.Linq;
using TenPinScoring.Contracts;
using TenPinScoring.Entities;
using TenPinScoring.Frames;

namespace TenPinScoring
{
    public class Game
    {
        private readonly List<IFrame> _frames = new List<IFrame>();

        public void SetupGame(int numberOfFrames)
        {
            for (int i = 0; i < numberOfFrames - 1; i++)
            {
                _frames.Add(new Frame(maxTurns: 2));
            }
            _frames.Add(new FinalFrame(maxTurns: 3));
        }

        public GameResult Play(Queue<int> rolls)
        {
            GameResult result = new GameResult();

            foreach (IFrame frame in _frames)
            {
                frame.PlayFrame(rolls);
            }

            for (int i = 0; i < _frames.Count; i++)
            {
                _frames[i].Score = _frames[i].FrameOutcome.CalculateScore(i, _frames);
                result.Outcomes.Add(_frames[i].FrameOutcome.OutcomeName);
            }

            result.FinalScore = _frames.Last().Score;

            return result;
        }
    }
}
