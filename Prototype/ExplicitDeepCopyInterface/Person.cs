using System;

namespace Prototype.ExplicitDeepCopyInterface;

public class Person : IPrototype<Person>
{
    public string[] Names { get; set; }

    public Address Address { get; set; }

    public Person(string[] names, Address address)
    {
        Names = names ?? throw new ArgumentNullException(nameof(names));
        Address = address ?? throw new ArgumentNullException(nameof(address));
    }

    public override string ToString()
    {
        return $"{string.Join(" ", Names)}, {Address}";
    }

    public Person DeepCopy()
    {
        return new Person(Names, Address.DeepCopy());
    }
}