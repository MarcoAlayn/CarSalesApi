using System;
using System.Collections.Generic;

namespace CarSalesApi.Models;

public partial class Car
{
    public Guid Guid { get; set; }

    public string? Model { get; set; }

    public int? TotalLengthMm { get; set; }

    public int? TotalWidthMm { get; set; }

    public int? TotalHeightMm { get; set; }

    public int? WheelbaseMm { get; set; }

    public decimal? Acceleration0100KmHSeconds { get; set; }

    public int? MaximumSpeedKmH { get; set; }

    public int? PowerKW { get; set; }

    public decimal? BatteryCapacityKWh { get; set; }

    public int? WltpRangeKm { get; set; }

    public string? ChargingTime0100Ac { get; set; }

    public string? ChargingTime1080Dc { get; set; }

    public int? CurbWeightKg { get; set; }

    public int? LoadCapacityKg { get; set; }

    public int? TrunkCapacityLiters { get; set; }

    public bool? Absbrakes { get; set; }

    public bool? TractionControl { get; set; }

    public bool? LaneKeepingAssist { get; set; }

    public bool? Airbags { get; set; }

    public bool? AutomaticClimateControl { get; set; }

    public bool? IntegratedNavigationSystem { get; set; }

    public bool? ElectricallyAdjustableSeats { get; set; }

    public bool? GlassPanoramicRoof { get; set; }

    public int? CentralTouchscreenInches { get; set; }

    public bool? BluetoothWiFiConnectivity { get; set; }

    public bool? PremiumSoundSystem { get; set; }

    public bool? AdjustableDrivingModes { get; set; }

    public decimal? BasePriceUsd { get; set; }

    public int? NumberOfSeats { get; set; }
}
