namespace Visitor.ClassicVisitor;

public class DoubleExpression : Expression
{
    public double Value { get; set; }

    public DoubleExpression(double value)
    {
        Value = value;
    }

    public override void Accept(IExpressionVisitor visitor)
    {
        // double dispatch
        visitor.Visit(this);
    }
}