namespace MemoryFlipCardGame.Models
{
    public class GameStats
    {
        public int Id { get; set; }
        public int TotalGamesPlayed { get; set; }
        public int TotalWins { get; set; }
        public int TotalTurns { get; set; }
        public int TotalFlips { get; set; }
        public int TotalMatches { get; set; }
        public int TotalMisses { get; set; }
        public TimeSpan FastestWinTime { get; set; }
        public int WinStreak { get; set; }
        public DateTime LastPlayed { get; set; }
        public int GainedXP { get; set; }
    }
}
