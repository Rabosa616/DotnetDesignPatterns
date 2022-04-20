using System;

namespace Prototype.CopyConstructors;

public class Person
{
    public string[] Names { get; set; }

    public Address Address { get; set; }

    public Person(string[] names, Address address)
    {
        Names = names ?? throw new ArgumentNullException(nameof(names));
        Address = address ?? throw new ArgumentNullException(nameof(address));
    }

    // Copy Constructor
    public Person(Person other)
    {
        Names = other.Names;
        Address = new Address(other.Address);
    }

    public override string ToString()
    {
        return $"{string.Join(" ", Names)}, {Address}";
    }
}