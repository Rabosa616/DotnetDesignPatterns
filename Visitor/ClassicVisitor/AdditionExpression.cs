namespace Visitor.ClassicVisitor;

public class AdditionExpression : Expression
{
    public Expression Left { get; set; }
    public Expression Right { get; set; }

    public AdditionExpression(Expression left, Expression right)
    {
        Left = left;
        Right = right;
    }

    public override void Accept(IExpressionVisitor visitor)
    {
        visitor.Visit(this);
    }
}