namespace Adapter.VectorRasterDemo;

public class Line
{
    public Point Start { get; set; }
    public Point End { get; set; }

    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    // Hash Code for unique object
    public override int GetHashCode()
    {
        unchecked
        {
            return ((Start != null ? Start.GetHashCode() : 0) * 397) ^ ((End != null ? End.GetHashCode() : 0) * 397);
        }
    }
}