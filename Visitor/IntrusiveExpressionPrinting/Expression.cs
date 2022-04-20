using System.Text;

namespace Visitor.IntrusiveExpressionPrinting;

public abstract class Expression
{
    public abstract void Print(StringBuilder sb);
}