using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Final_Api.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Temple> Temples { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Server=dorian-db-svc;Database=test-db;User Id=test-user;Password=test-password;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Temple>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("temples_pkey");

            entity.ToTable("temples");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
