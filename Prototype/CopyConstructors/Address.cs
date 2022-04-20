using System;

namespace Prototype.CopyConstructors;

public class Address
{
    public string StreetName { get; set; }

    public int HouseNumber { get; set; }

    public Address(string streetName, int houseNumber)
    {
        StreetName = streetName ?? throw new ArgumentNullException(nameof(streetName));
        HouseNumber = houseNumber;
    }

    // Copy constructor
    public Address(Address other)
    {
        StreetName = other.StreetName;
        HouseNumber = other.HouseNumber;
    }

    public override string ToString()
    {
        return $"{StreetName}, {HouseNumber}";
    }
}