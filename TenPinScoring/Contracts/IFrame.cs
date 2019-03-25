using System.Collections.Generic;
using TenPinScoring.Entities;

namespace TenPinScoring.Contracts
{
    public interface IFrame
    {
        IFrameOutcome FrameOutcome { get; }

        int Score { get; set; }

        List<Turn> Turns { get; }

        void PlayFrame(Queue<int> rolls);
    }
}
