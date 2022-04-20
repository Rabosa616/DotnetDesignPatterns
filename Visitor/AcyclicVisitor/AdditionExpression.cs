namespace Visitor.AcyclicVisitor;

public class AdditionExpression : Expression
{
    public Expression Left { get; set; }
    public Expression Right { get; set; }

    public override void Accept(IVisitor visitor)
    {
        if (visitor is IVisitor<AdditionExpression> typed)
        {
            typed.Visit(this);
        }
    }
}