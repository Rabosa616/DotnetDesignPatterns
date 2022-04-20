namespace Visitor.DynamicVisitorViaDLR;

public class AdditionExpression : Expression
{
    public Expression Left { get; set; }
    public Expression Right { get; set; }

    public AdditionExpression(Expression left, Expression right)
    {
        Left = left;
        Right = right;
    }
}