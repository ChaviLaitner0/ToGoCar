using System;
using System.Collections.Generic;

namespace project.Models;

public partial class BlRental
{
    public BlRental() { }
    public BlRental(int id, string idSubscriber, string carNumber, string routess, int amount, int km)
    {
        Id = id;
        IdSubscriber = idSubscriber;
        CarNumber = carNumber;
        Routess = routess;
        Amount = amount;
        Km = km;
    }

    public int Id { get; set; }

    public string IdSubscriber { get; set; } = null!;

    public string CarNumber { get; set; } = null!;

    public string Routess { get; set; }

    public int Amount { get; set; }

    public int Km { get; set; }

    public virtual BlCar CarNumberNavigation { get; set; } = null!;

    public virtual BlSubscriber IdSubscriberNavigation { get; set; } = null!;

    public virtual Routess? RoutessNavigation { get; set; }
}
