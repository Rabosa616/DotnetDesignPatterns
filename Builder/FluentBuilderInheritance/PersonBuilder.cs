namespace Builder.FluentBuilderInheritance;

public abstract class PersonBuilder
{
    protected Person person = new();

    public Person Build() => person;
}