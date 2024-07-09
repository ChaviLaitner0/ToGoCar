using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal.Models;

public partial class BridalContext : DbContext
{
    public BridalContext(DbContextOptions<BridalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<CarRoute> CarRoutes { get; set; }

    public virtual DbSet<CarType> CarTypes { get; set; }

    public virtual DbSet<Parking> Parkings { get; set; }

    public virtual DbSet<Rental> Rentals { get; set; }

    public virtual DbSet<Routess> Routesses { get; set; }

    public virtual DbSet<Subscriber> Subscribers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.CarNumber).HasName("PK__Cars__655D1FBC206779CC");

            entity.Property(e => e.CarNumber)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.CarType)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Model)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<CarRoute>(entity =>
        {
            entity.HasKey(e => e.CarType).HasName("PK__CarRoute__D325B2823CF0C4D4");

            entity.ToTable("CarRoute");

            entity.Property(e => e.CarType).ValueGeneratedNever();
            entity.Property(e => e.CodeRoute)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.PriceKm).HasColumnName("PriceKM");
        });

        modelBuilder.Entity<CarType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__CarType__3214EC07119400F0");

            entity.ToTable("CarType");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("type");
        });

        modelBuilder.Entity<Parking>(entity =>
        {
            entity.HasKey(e => e.ParkingNumber).HasName("PK__Parking__1F7DB4E6B77C6BCC");

            entity.ToTable("Parking");

            entity.Property(e => e.ParkingNumber).ValueGeneratedNever();
            entity.Property(e => e.City)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PostalCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Street)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Rental>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Rentals__3214EC079B3F0EBF");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CarNumber)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.IdSubscriber)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Km).HasColumnName("KM");
            entity.Property(e => e.Routess)
                .HasMaxLength(4)
                .IsFixedLength();
        });

        modelBuilder.Entity<Routess>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Routess__A25C5AA6BFFBC4BE");

            entity.ToTable("Routess");

            entity.Property(e => e.Code)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Subscriber>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Subscrib__3214EC07B683CE4A");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.LicenseNumber)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
