namespace Adapter.VectorRasterDemo;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Hash Code for unique object
    public override int GetHashCode()
    {
        unchecked
        {
            return (X * 397) ^ Y;
        }
    }
}