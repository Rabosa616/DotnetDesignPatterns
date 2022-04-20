using System.Collections.Generic;
using System.Linq;

namespace SOLID.DependencyInversion;

// High level parts dont need to depend directly to low level parts
// Instead of this, high level parts should be depending of some kind of abstraction
public enum Relationship
{
    Parent,
    Child,
    Sibling
}

public class Person
{
    public string Name;
    // ....
}

// low-level
public class Relationships
{
    private readonly List<(Person, Relationship, Person)> relations = new();

    public void AddParentAndChild(Person parent, Person child)
    {
        relations.Add((parent, Relationship.Parent, child));
        relations.Add((child, Relationship.Child, parent));
    }

    // If a way to expose incorrectly the private list for the high-level
    public List<(Person, Relationship, Person)> Relations => relations;
}

// The idea is create an interface to find a particular information about the relations
// Instead to use directly the list of relations
public interface IRelationshipBrowser
{
    IEnumerable<Person> FindAllChildrenOf(string name);
}

public class GoodRelationships : IRelationshipBrowser
{
    private readonly List<(Person, Relationship, Person)> relations = new();

    public void AddParentAndChild(Person parent, Person child)
    {
        relations.Add((parent, Relationship.Parent, child));
        relations.Add((child, Relationship.Child, parent));
    }

    // We are returning the information with an abstraction instead the low level (in this case is the list)
    public IEnumerable<Person> FindAllChildrenOf(string name)
    {
        return relations.Where(
            m => m.Item1.Name == name &&
                 m.Item2 == Relationship.Parent).Select(r => r.Item3);
    }
}