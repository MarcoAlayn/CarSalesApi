using System;
using System.Collections.Generic;

namespace CarSalesApi.Models;

public partial class Customer
{
    public Guid Guid { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? PasswordHash { get; set; }

    public string? City { get; set; }

    public string? Address { get; set; }

    public string? PostalCode { get; set; }

    public string? PhoneNumber { get; set; }

    public string? PreferredContactMethod { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public bool? IsActive { get; set; }
}
