namespace Visitor.ClassicVisitor;

public interface IExpressionVisitor
{
    void Visit(AdditionExpression ae);

    void Visit(DoubleExpression de);
}