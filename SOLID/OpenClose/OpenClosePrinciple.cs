using System;
using System.Collections.Generic;

namespace SOLID.OpenClose;

public enum Color
{
    Red, Green, Blue
}

public enum Size
{
    Small, Medium, Large, Yuge
}

public class Product
{
    public string Name;
    public Color Color;
    public Size Size;

    public Product(string name, Color color, Size size)
    {
        Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
        Color = color;
        Size = size;
    }
}

// With adding the new functionality we are broken the open close principle (adding new code instead to extend)
public class ProductFilter
{
    // First approach filtering by Size
    public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
    {
        foreach (var p in products)
        {
            if (p.Size == size)
            {
                yield return p;
            }
        }
    }

    // Now the PO asks to add the functionality to filter by color
    public static IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
    {
        foreach (var p in products)
        {
            if (p.Color == color)
            {
                yield return p;
            }
        }
    }

    // Now they want to add a new functionality to filter by size and color
    public static IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Color color, Size size)
    {
        foreach (var p in products)
        {
            if (p.Color == color && p.Size == size)
            {
                yield return p;
            }
        }
    }
}

// The good approach is with Specification pattern
public interface ISpecification<T>
{
    // Allow people to check Specification to check if satisfy a criteria
    bool IsSatisfied(T t);
}

// Filter mechanism with any type T
public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
}

// We can create a specification to see if is satisfied by color
public class ColorSpecification : ISpecification<Product>
{
    private readonly Color color;

    public ColorSpecification(Color color)
    {
        this.color = color;
    }

    public bool IsSatisfied(Product t)
    {
        return t.Color == color;
    }
}

// Same for Size
public class SizeSpecification : ISpecification<Product>
{
    private readonly Size size;

    public SizeSpecification(Size size)
    {
        this.size = size;
    }

    public bool IsSatisfied(Product t)
    {
        return t.Size == size;
    }
}

// To combine different specifications
public class AndSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> first, second;

    public AndSpecification(ISpecification<T> first, ISpecification<T> second)
    {
        this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
        this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
    }

    public bool IsSatisfied(T t)
    {
        return first.IsSatisfied(t) && second.IsSatisfied(t);
    }
}

// And the filter
public class BetterFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
    {
        foreach (var i in items)
        {
            if (spec.IsSatisfied(i))
            {
                yield return i;
            }
        }
    }
}