using System.Text;

namespace Visitor.IntrusiveExpressionPrinting;

public class AdditionExpression : Expression
{
    private readonly Expression left;
    private readonly Expression right;

    public AdditionExpression(Expression left, Expression right)
    {
        this.left = left;
        this.right = right;
    }

    public override void Print(StringBuilder sb)
    {
        sb.Append('(');
        left.Print(sb);
        sb.Append('+');
        right.Print(sb);
        sb.Append(')');
    }
}