using System.Text;

namespace Visitor.AcyclicVisitor;

public class ExpressionPrinter : IVisitor, IVisitor<Expression>, IVisitor<DoubleExpression>, IVisitor<AdditionExpression>
{
    private readonly StringBuilder sb = new();

    public void Visit(Expression obj)
    {
    }

    public void Visit(AdditionExpression obj)
    {
        sb.Append('(');
        obj.Left.Accept(this);
        sb.Append('+');
        obj.Right.Accept(this);
        sb.Append(')');
    }

    public void Visit(DoubleExpression obj)
    {
        sb.Append(obj.Value);
    }

    public override string ToString()
    {
        return sb.ToString();
    }
}