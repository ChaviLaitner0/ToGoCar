using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class CarRoute
{
    public int CarType { get; set; }

    public string? CodeRoute { get; set; }

    public int? PriceRoute { get; set; }

    public int? PriceKm { get; set; }
}
