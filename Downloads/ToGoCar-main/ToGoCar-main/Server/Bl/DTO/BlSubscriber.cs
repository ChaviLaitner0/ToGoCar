using System;
using System.Collections.Generic;

namespace project.Models;

public partial class BlSubscriber
{

    public BlSubscriber() {}
    public BlSubscriber(string id, int age, string licenseNumber, string firstName, string lastName, string phone)
    {
        Id = id;
        Age = age;
        LicenseNumber = licenseNumber;
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
    }
    public string Id { get; set; } = null!;

    public int Age { get; set; }

    public string LicenseNumber { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; }

    public string Phone { get; set; } = null!;

    public virtual ICollection<BlRental> Rentals { get; set; } = new List<BlRental>();


}
