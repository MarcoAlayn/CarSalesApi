using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CarSalesApi.Models;

public partial class CarSalesDbContext : DbContext
{
    public CarSalesDbContext()
    {
    }

    public CarSalesDbContext(DbContextOptions<CarSalesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ModelSpecification> ModelSpecifications { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:servercarsales.database.windows.net,1433;Initial Catalog=CarSalesDB;Persist Security Info=False;User ID=marco;Password=@abc123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ModelSpecification>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PK__ModelSpe__A2B5777C0D1A97E8");

            entity.HasIndex(e => e.Model, "UQ__ModelSpe__FB104C138DCB30A2").IsUnique();

            entity.Property(e => e.Guid).ValueGeneratedNever();
            entity.Property(e => e.Acceleration0100Kmh)
                .HasMaxLength(100)
                .HasColumnName("Acceleration_0_100_kmh");
            entity.Property(e => e.AutonomyKm)
                .HasMaxLength(100)
                .HasColumnName("Autonomy_km");
            entity.Property(e => e.DragCoefficient).HasMaxLength(50);
            entity.Property(e => e.LoadCapacityL)
                .HasMaxLength(50)
                .HasColumnName("LoadCapacity_l");
            entity.Property(e => e.MaxSuperchargerKW).HasColumnName("MaxSupercharger_kW");
            entity.Property(e => e.MaximumPowerHp)
                .HasMaxLength(50)
                .HasColumnName("MaximumPower_hp");
            entity.Property(e => e.MaximumSpeedKmh)
                .HasMaxLength(150)
                .HasColumnName("MaximumSpeed_kmh");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PropulsionSystem).HasMaxLength(50);
            entity.Property(e => e.QuarterMile).HasMaxLength(100);
            entity.Property(e => e.Rims).HasMaxLength(50);
            entity.Property(e => e.Warranty).HasMaxLength(255);
            entity.Property(e => e.WeightKg)
                .HasMaxLength(50)
                .HasColumnName("Weight_kg");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
