namespace Builder.FacetedBuilder;

// Facade to expose other builders
public class PersonBuilder
{
    // Reference
    protected Person person = new();

    public PersonJobBuilder Works => new(person);

    public PersonAddressBuilder Lives => new(person);

    // Used to use Person instead of PersonBuilder
    public static implicit operator Person(PersonBuilder personBuilder)
    {
        return personBuilder.person;
    }
}