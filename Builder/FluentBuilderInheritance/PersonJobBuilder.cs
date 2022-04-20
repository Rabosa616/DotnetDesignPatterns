namespace Builder.FluentBuilderInheritance;

// Instead of modify the first builder, we create a new one and inherit PersonInfoBuilder
public class PersonJobBuilder<SELF> : PersonInfoBuilder<PersonJobBuilder<SELF>> where SELF : PersonJobBuilder<SELF>
{
    public SELF WorksAsA(string position)
    {
        person.Position = position;
        return (SELF)this;
    }
}