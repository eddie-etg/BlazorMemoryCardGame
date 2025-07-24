using System;
using System.Collections.Generic;
using MemoryFlipCardGame.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace MemoryFlipCardGame.Data;

public partial class MemoryCardContext : DbContext
{
    public MemoryCardContext()
    {
    }

    public MemoryCardContext(DbContextOptions<MemoryCardContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ScoreLeaderboard> ScoreLeaderboards { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=BlueRasp444\\SQLEXPRESS;Database=MemoryCardGameDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ScoreLeaderboard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ScoreLea__3214EC078DCEBAF8");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
