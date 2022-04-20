namespace Decorator.DynamicDecoratorComposition;

// Decorator
public class TransparentShape : IShape
{
    private readonly IShape shape;
    private readonly float transparency;

    public TransparentShape(IShape shape, float transparency)
    {
        this.shape = shape;
        this.transparency = transparency;
    }

    public string AsString() => $"{shape.AsString()} has {transparency * 100.0}% transparency";
}