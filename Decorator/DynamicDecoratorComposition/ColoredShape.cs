namespace Decorator.DynamicDecoratorComposition;

// Decorator
public class ColoredShape : IShape
{
    private readonly IShape shape;
    private readonly string color;

    public ColoredShape(IShape shape, string color)
    {
        this.shape = shape;
        this.color = color;
    }

    public string AsString() => $"{shape.AsString()} has the color {color}";
}