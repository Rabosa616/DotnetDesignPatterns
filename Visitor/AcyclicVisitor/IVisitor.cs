namespace Visitor.AcyclicVisitor;

public interface IVisitor<TVisitable>
{
    void Visit(TVisitable obj);
}

// Used as a mock interface
public interface IVisitor { }