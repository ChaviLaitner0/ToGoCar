using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Subscriber
{
    public string Id { get; set; } = null!;

    public int Age { get; set; }

    public string LicenseNumber { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string Phone { get; set; } = null!;
}
