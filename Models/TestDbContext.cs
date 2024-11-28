using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Advanced_Frontend_Final_Api.Models;

public partial class TestDbContext : DbContext
{

    public TestDbContext(DbContextOptions<TestDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Temple> Temples { get; set; }

    public virtual DbSet<Visit> Visits { get; set; }

    public virtual DbSet<Visitphoto> Visitphotos { get; set; }

        //"Host=localhost;Port=5432;Database=test-db;Username=test-user;Password=test-password"

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("people_pkey");

            entity.ToTable("people");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Fname).HasColumnName("fname");
            entity.Property(e => e.Lname).HasColumnName("lname");
            entity.Property(e => e.Pfpurl).HasColumnName("pfpurl");
        });

        modelBuilder.Entity<Temple>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("temples_pkey");

            entity.ToTable("temples");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Mailaddress).HasColumnName("mailaddress");
            entity.Property(e => e.Photourl).HasColumnName("photourl");
            entity.Property(e => e.Pluscode).HasColumnName("pluscode");
            entity.Property(e => e.Templename).HasColumnName("templename");
        });

        modelBuilder.Entity<Visit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("visits_pkey");

            entity.ToTable("visits");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.Templeid).HasColumnName("templeid");
            entity.Property(e => e.Visittime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("visittime");

            entity.HasOne(d => d.Temple).WithMany(p => p.Visits)
                .HasForeignKey(d => d.Templeid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_temple");
        });

        modelBuilder.Entity<Visitphoto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("visitphotos_pkey");

            entity.ToTable("visitphotos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Photourl).HasColumnName("photourl");
            entity.Property(e => e.Visitid).HasColumnName("visitid");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
