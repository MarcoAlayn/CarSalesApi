using System;
using System.Collections.Generic;

namespace CarSalesApi.Models;

public partial class ModelSpecification
{
    public Guid Guid { get; set; }

    public string? Model { get; set; }

    public string? AutonomyKm { get; set; }

    public string? QuarterMile { get; set; }

    public string? MaximumPowerHp { get; set; }

    public string? Acceleration0100Kmh { get; set; }

    public string? Rims { get; set; }

    public string? LoadCapacityL { get; set; }

    public string? WeightKg { get; set; }

    public string? MaximumSpeedKmh { get; set; }

    public string? DragCoefficient { get; set; }

    public string? PropulsionSystem { get; set; }

    public int? MaxSuperchargerKW { get; set; }

    public string? Warranty { get; set; }
}
