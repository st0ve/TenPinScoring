using System.Collections.Generic;

namespace TenPinScoring.Entities
{
    public class GameResult
    {
        public List<string> Outcomes = new List<string>();

        public int FinalScore { get; set; }
    }
}
