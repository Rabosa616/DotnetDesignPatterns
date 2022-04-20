using System;

namespace Prototype.CopyThroughSerialization;

public class Address
{
    public string StreetName { get; set; }

    public int HouseNumber { get; set; }

    public Address(string streetName, int houseNumber)
    {
        StreetName = streetName ?? throw new ArgumentNullException(nameof(streetName));
        HouseNumber = houseNumber;
    }

    public override string ToString()
    {
        return $"{StreetName}, {HouseNumber}";
    }
}