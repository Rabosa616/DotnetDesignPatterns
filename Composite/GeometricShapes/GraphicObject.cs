using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.GeometricShapes;

public class GraphicObject
{
    public string Color { get; set; }

    public virtual string Name { get; set; } = "Group";

    private readonly Lazy<List<GraphicObject>> children = new();
    public List<GraphicObject> Children => children.Value;

    private void Print(StringBuilder sb, int depth)
    {
        sb.Append(new string('*', depth)).Append(string.IsNullOrWhiteSpace(Color) ? string.Empty : $"{Color} ").Append(Name);

        foreach (var child in Children)
        {
            child.Print(sb, depth + 1);
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        Print(sb, 0);
        return sb.ToString();
    }
}