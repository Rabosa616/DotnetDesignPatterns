namespace Builder.FunctionalBuilder;

// To mantain open close for PersonBuilder if we want to introduce more builders
public static class PersonBuilderExtensions
{
    public static PersonBuilder WorksAs(this PersonBuilder builder, string position) => builder.Do(p => p.Position = position);
}