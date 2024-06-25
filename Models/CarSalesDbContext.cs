using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CarSalesApi.Models;

public partial class CarSalesDbContext : DbContext
{
    private readonly IConfiguration _configuration;
    public CarSalesDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public CarSalesDbContext(DbContextOptions<CarSalesDbContext> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = _configuration.GetConnectionString("CarSalesDB");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PK__Cars__A2B5777C05806D13");

            entity.HasIndex(e => e.Model, "UQ__Cars__FB104C13A87E1243").IsUnique();

            entity.Property(e => e.Guid).ValueGeneratedNever();
            entity.Property(e => e.Absbrakes).HasColumnName("ABSBrakes");
            entity.Property(e => e.Acceleration0100KmHSeconds)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("Acceleration_0_100_km_h_seconds");
            entity.Property(e => e.BasePriceUsd)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("BasePrice_USD");
            entity.Property(e => e.BatteryCapacityKWh)
                .HasColumnType("decimal(5, 1)")
                .HasColumnName("BatteryCapacity_kWh");
            entity.Property(e => e.CentralTouchscreenInches).HasColumnName("CentralTouchscreen_inches");
            entity.Property(e => e.ChargingTime0100Ac)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ChargingTime_0_100_AC");
            entity.Property(e => e.ChargingTime1080Dc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ChargingTime_10_80_DC");
            entity.Property(e => e.CurbWeightKg).HasColumnName("CurbWeight_kg");
            entity.Property(e => e.LoadCapacityKg).HasColumnName("LoadCapacity_kg");
            entity.Property(e => e.MaximumSpeedKmH).HasColumnName("MaximumSpeed_km_h");
            entity.Property(e => e.Model)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PowerKW).HasColumnName("Power_kW");
            entity.Property(e => e.TotalHeightMm).HasColumnName("TotalHeight_mm");
            entity.Property(e => e.TotalLengthMm).HasColumnName("TotalLength_mm");
            entity.Property(e => e.TotalWidthMm).HasColumnName("TotalWidth_mm");
            entity.Property(e => e.TrunkCapacityLiters).HasColumnName("TrunkCapacity_liters");
            entity.Property(e => e.WheelbaseMm).HasColumnName("Wheelbase_mm");
            entity.Property(e => e.WltpRangeKm).HasColumnName("WLTP_Range_km");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PK__Customer__A2B5777C71EA0FBB");

            entity.HasIndex(e => e.Email, "UQ__Customer__A9D105344AB55275").IsUnique();

            entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PostalCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PreferredContactMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegistrationDate).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
