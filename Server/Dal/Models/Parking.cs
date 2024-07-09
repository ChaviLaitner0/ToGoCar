using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Parking
{
    public int ParkingNumber { get; set; }

    public string City { get; set; } = null!;

    public string? Street { get; set; }

    public string PostalCode { get; set; } = null!;
}
