using TenPinScoring.Contracts;

namespace TenPinScoringTests.Mocks
{
    internal class MockTurn : ITurn
    {
        public int PinsKnocked { get; set; }
        public void Roll()
        {
            throw new System.NotImplementedException();
        }
    }
}
