namespace MemoryFlipCardGame.Models
{
    public class GameSession
    {
        public int Turns { get; set; }
        public int Matches { get; set; }
        public int Flips { get; set; }
        public int MissedMatches { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool GameWon { get; set; }
    }
}
