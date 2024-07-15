using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Rental
{
    public int Id { get; set; }

    public string IdSubscriber { get; set; } = null!;

    public string CarNumber { get; set; } = null!;

    public string Routess { get; set; }

    public int Amount { get; set; }

    public int Km { get; set; }
}
