using System.Text;

namespace Visitor.IntrusiveExpressionPrinting;

public class DoubleExpression : Expression
{
    private readonly double value;

    public DoubleExpression(double value)
    {
        this.value = value;
    }

    public override void Print(StringBuilder sb)
    {
        sb.Append(value);
    }
}