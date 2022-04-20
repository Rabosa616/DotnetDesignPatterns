namespace Builder.FluentBuilderInheritance;

public class Person
{
    public string Name { get; set; }

    public string Position { get; set; }

    public static Builder New => new();

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
    }

    public class Builder : PersonJobBuilder<Builder>
    {
    }
}