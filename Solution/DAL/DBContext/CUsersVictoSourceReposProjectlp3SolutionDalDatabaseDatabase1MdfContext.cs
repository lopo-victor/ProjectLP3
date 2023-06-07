using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.DBContext;
using MODEL;

public partial class CUsersVictoSourceReposProjectlp3SolutionDalDatabaseDatabase1MdfContext : DbContext
{
    public CUsersVictoSourceReposProjectlp3SolutionDalDatabaseDatabase1MdfContext()
    {
    }

    public CUsersVictoSourceReposProjectlp3SolutionDalDatabaseDatabase1MdfContext(DbContextOptions<CUsersVictoSourceReposProjectlp3SolutionDalDatabaseDatabase1MdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbPartida> TbPartida { get; set; }

    public virtual DbSet<TbPlayer> TbPlayers { get; set; }

    public virtual DbSet<TbPlayerPartida> TbPlayerPartida { get; set; }

    public virtual DbSet<TbTime> TbTimes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\victo\\source\\repos\\ProjectLP3\\Solution\\DAL\\database\\Database1.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbPartida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_parti__3214EC075D8BD1B2");

            entity.ToTable("tb_partida");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.WinsAzul).HasColumnName("winsAzul");
            entity.Property(e => e.WinsLaranja).HasColumnName("winsLaranja");
        });

        modelBuilder.Entity<TbPlayer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_Playe__3214EC07BC604F4E");

            entity.ToTable("tb_Player");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Assists).HasColumnName("assists");
            entity.Property(e => e.Deaths).HasColumnName("deaths");
            entity.Property(e => e.Derrotas).HasColumnName("derrotas");
            entity.Property(e => e.Kills).HasColumnName("kills");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.UserName)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("userName");
            entity.Property(e => e.Vitorias).HasColumnName("vitorias");
        });

        modelBuilder.Entity<TbPlayerPartida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_Playe__3214EC07F9671600");

            entity.ToTable("tb_PlayerPartida");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Assists).HasColumnName("assists");
            entity.Property(e => e.Deaths).HasColumnName("deaths");
            entity.Property(e => e.IdPlayer).HasColumnName("idPlayer");
            entity.Property(e => e.Kills).HasColumnName("kills");
            entity.Property(e => e.Pontos).HasColumnName("pontos");
        });

        modelBuilder.Entity<TbTime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_Time__3214EC07FFE7384B");

            entity.ToTable("tb_Time");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdPartida).HasColumnName("id_partida");
            entity.Property(e => e.IdPlayerPartida).HasColumnName("id_playerPartida");
            entity.Property(e => e.Time)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("time");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
