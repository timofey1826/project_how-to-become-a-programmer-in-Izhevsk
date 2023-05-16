using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace aspnetcoreapp;

public partial class PostgresContext : DbContext
{
    public PostgresContext()
    {
    }

    public PostgresContext(DbContextOptions<PostgresContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Anketum> Anketa { get; set; }

    public virtual DbSet<Dbnet> Dbnets { get; set; }

    public virtual DbSet<Driver> Drivers { get; set; }

    public virtual DbSet<Email> Emails { get; set; }

    public virtual DbSet<Realthing> Realthings { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("pg_catalog", "adminpack");

        modelBuilder.Entity<Anketum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("anketa", "Team");

            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
        });

        modelBuilder.Entity<Dbnet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbnet", "Team");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nickname)
                .HasColumnType("character varying")
                .HasColumnName("nickname");
        });

        modelBuilder.Entity<Driver>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("driver", "Team");
        });

        modelBuilder.Entity<Email>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("email", "Team");

            entity.Property(e => e.Email1)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Realthing>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("realthings", "Team");

            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Realname)
                .HasColumnType("character varying")
                .HasColumnName("realname");
            entity.Property(e => e.Weaght).HasColumnName("weaght");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("team", "Team");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
