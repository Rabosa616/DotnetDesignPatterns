using System;

namespace Prototype.ExplicitDeepCopyInterface;

public class Address : IPrototype<Address>
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

    public Address DeepCopy()
    {
        return new Address(StreetName, HouseNumber);
    }
}