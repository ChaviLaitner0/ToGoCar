using System;
using System.Collections.Generic;

namespace project.Models;

public partial class BlParking
{
   public BlParking() { }
    public BlParking(int parkingNumber, string? city, string street, string? postalCode)
    { 
        this.ParkingNumber = parkingNumber;
        this.City = city;
        this.Street = street;
        this.PostalCode = postalCode;

    }
    public int ParkingNumber { get; set; }

    public string City { get; set; } = null!;

    public string? Street { get; set; }

    public string PostalCode { get; set; } = null!;

    public virtual ICollection<BlCar> Cars { get; set; } = new List<BlCar>();
}
