using System.Text;

namespace Visitor.DynamicVisitorViaDLR;

public class ExpressionPrinter
{
    public void Print(AdditionExpression ae, StringBuilder sb)
    {
        sb.Append('(');
        Print((dynamic)ae.Left, sb);
        sb.Append('+');
        Print((dynamic)ae.Right, sb);
        sb.Append(')');
    }

    public static void Print(DoubleExpression de, StringBuilder sb)
    {
        sb.Append(de.Value);
    }
}