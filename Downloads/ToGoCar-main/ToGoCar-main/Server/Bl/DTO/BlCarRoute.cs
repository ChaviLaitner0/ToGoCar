using System;
using System.Collections.Generic;

namespace project.Models;

public partial class BlCarRoute
{
    public int CarType { get; set; }

    public string CodeRoute { get; set; } = null!;

    public int PriceRoute { get; set; }

    public int PriceKm { get; set; }

    public virtual BlCarType CarTypeNavigation { get; set; } = null!;

    public virtual Routess CodeRouteNavigation { get; set; } = null!;
}
