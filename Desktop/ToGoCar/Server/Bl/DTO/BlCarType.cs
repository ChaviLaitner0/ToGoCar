using System;
using System.Collections.Generic;

namespace project.Models;

public partial class BlCarType
{
    public int Code { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<BlCar> Cars { get; set; } = new List<BlCar>();
}
