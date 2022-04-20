using System.Text;

namespace Visitor.ClassicVisitor;

public class ExpressionPrinter : IExpressionVisitor
{
    private readonly StringBuilder sb = new();

    public void Visit(DoubleExpression de)
    {
        sb.Append(de.Value);
    }

    public void Visit(AdditionExpression ae)
    {
        sb.Append('(');
        ae.Left.Accept(this);
        sb.Append('+');
        ae.Right.Accept(this);
        sb.Append(')');
    }

    public override string ToString()
    {
        return sb.ToString();
    }
}