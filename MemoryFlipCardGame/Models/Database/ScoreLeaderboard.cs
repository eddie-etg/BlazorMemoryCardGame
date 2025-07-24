using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MemoryFlipCardGame.Models.Database;

[Table("ScoreLeaderboard")]
public partial class ScoreLeaderboard
{
    [Key]
    public int Id { get; set; }

    [StringLength(9)]
    public string? PlayerName { get; set; }

    public int? Wins { get; set; }

    public int? TotalFlips { get; set; }

    public int? TotalMatches { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DatePlayed { get; set; }
}
