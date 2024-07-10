using System;
using System.Collections.Generic;

namespace project.Models;

public partial class BlCar
{
   
    public BlCar() { }
    public BlCar(string carNumber, string model, int carType, int parkingNumber, int amount)
    {
        CarNumber = carNumber;
        Model = model;
        CarType = carType;
        ParkingNumber = parkingNumber;
        Amount = amount;

    }
 
    public string CarNumber { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int CarType { get; set; }

    public int ParkingNumber { get; set; }

    public int Amount { get; set; }

    public virtual BlCarType CarTypeNavigation { get; set; } = null!;

    public virtual BlParking ParkingNumberNavigation { get; set; } = null!;

    public virtual ICollection<BlRental> Rentals { get; set; } = new List<BlRental>();
}
