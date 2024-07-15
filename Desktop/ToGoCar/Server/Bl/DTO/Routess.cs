using System;
using System.Collections.Generic;

namespace project.Models;

public partial class Routess
{
    public string Code { get; set; } = null!;

    public string? Type { get; set; }

    public virtual ICollection<BlRental> Rentals { get; set; } = new List<BlRental>();
}
