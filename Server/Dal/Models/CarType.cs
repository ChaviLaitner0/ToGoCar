using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class CarType
{
    public int Code { get; set; }

    public string Type { get; set; } = null!;
}
