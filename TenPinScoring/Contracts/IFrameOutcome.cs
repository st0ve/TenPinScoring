using System.Collections.Generic;

namespace TenPinScoring.Contracts
{
    public interface IFrameOutcome
    {
        string OutcomeName { get; }

        int CalculateScore(int index, List<IFrame> frames);
    }
}
