namespace Builder.Builder;

// This builder pattern helps us to create the different elements directly into the builder
public class HtmlBuilder
{
    private readonly string rootName;
    private HtmlElement root = new();

    public HtmlBuilder(string rootName)
    {
        this.rootName = rootName;
        root.Name = rootName;
    }

    // Instead of void, we can return the HtmlBuilder
    public HtmlBuilder AddChild(string childName, string childText)
    {
        var element = new HtmlElement(childName, childText);
        root.Elements.Add(element);

        return this;
    }

    public override string ToString()
    {
        return root.ToString();
    }

    public void Clear()
    {
        root = new HtmlElement { Name = rootName };
    }
}