namespace SOLID.LiskovSubstitution;

// You must be able to substitute a sub-type object for his base object
public class Rectangle
{
    public int Width { get; set; }

    public int Height { get; set; }

    public Rectangle()
    {
    }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public override string ToString()
    {
        return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
    }
}

public class Square : Rectangle
{
    // With this implementation if you try to change Square for his base
    // Rectangle sq = new Square();
    // This will be fail with Height: 0
    // Liskov Substitution says you can change the object for his base and continue working fine
    public new int Width
    {
        set
        {
            base.Width = base.Height = value;
        }
    }

    public new int Height
    {
        set
        {
            base.Width = base.Height = value;
        }
    }
}

public class GoodRectangle
{
    // Adding virtual you can override in the inherit class
    public virtual int Width { get; set; }

    public virtual int Height { get; set; }

    public GoodRectangle()
    {
    }

    public GoodRectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public override string ToString()
    {
        return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
    }
}

public class GoodSquare : GoodRectangle
{
    public override int Width
    {
        set
        {
            base.Width = base.Height = value;
        }
    }

    public override int Height
    {
        set
        {
            base.Width = base.Height = value;
        }
    }
}