namespace Builder.FluentBuilderInheritance;

// To keep recursive generics
// For example Foo : Bar<Foo>
public class PersonInfoBuilder<SELF> : PersonBuilder where SELF : PersonInfoBuilder<SELF>
{
    protected Person person = new();

    public SELF Called(string name)
    {
        person.Name = name;
        return (SELF)this;
    }
}