using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Car
{
    public string CarNumber { get; set; } = null!;

    public string Model { get; set; }

    public int CarType { get; set; }

    public int ParkingNumber { get; set; }

    public int Amount { get; set; }
}
