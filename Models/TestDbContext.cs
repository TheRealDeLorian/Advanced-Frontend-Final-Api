using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Advanced_Frontend_Final_Api.Models;

public partial class TestDbContext : DbContext
{
    public TestDbContext()
    {
    }

    public TestDbContext(DbContextOptions<TestDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Temple> Temples { get; set; }

    public virtual DbSet<Visit> Visits { get; set; }

    public virtual DbSet<VisitPhoto> VisitPhotos { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //     => optionsBuilder.UseNpgsql("Host=localhost;db=test-db;Username=test-user;Password=test-password;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("person_pkey");

            entity.ToTable("person");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Fname).HasColumnName("fname");
            entity.Property(e => e.Lname).HasColumnName("lname");
            entity.Property(e => e.Pfpurl).HasColumnName("pfpurl");
        });

        modelBuilder.Entity<Temple>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("temple_pkey");

            entity.ToTable("temple");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Lat).HasColumnName("lat");
            entity.Property(e => e.Long).HasColumnName("long");
            entity.Property(e => e.Mailaddress).HasColumnName("mailaddress");
            entity.Property(e => e.Photourl).HasColumnName("photourl");
            entity.Property(e => e.Templename).HasColumnName("templename");
        });

        modelBuilder.Entity<Visit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("visit_pkey");

            entity.ToTable("visit");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.Personid).HasColumnName("personid");
            entity.Property(e => e.Templeid).HasColumnName("templeid");
            entity.Property(e => e.Visittime)
                .HasColumnType("timestamp with time zone")
                .HasColumnName("visittime");

            entity.HasOne(d => d.Person).WithMany(p => p.Visits)
                .HasForeignKey(d => d.Personid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_person");

            entity.HasOne(d => d.Temple).WithMany(p => p.Visits)
                .HasForeignKey(d => d.Templeid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_temple");
        });

        modelBuilder.Entity<VisitPhoto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("visit_photo_pkey");

            entity.ToTable("visit_photo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Photourl).HasColumnName("photourl");
            entity.Property(e => e.Visitid).HasColumnName("visitid");

            entity.HasOne(d => d.Visit).WithMany(p => p.VisitPhotos)
                .HasForeignKey(d => d.Visitid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_visit");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
