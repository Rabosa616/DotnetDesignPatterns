namespace Visitor.DynamicVisitorViaDLR;

public class DoubleExpression : Expression
{
    public double Value { get; set; }

    public DoubleExpression(double value)
    {
        Value = value;
    }
}