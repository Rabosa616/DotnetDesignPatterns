using System.Text;

namespace Decorator.CustomStringBuilder;

public class CodeBuilder
{
    private readonly StringBuilder builder = new();

    // We can do it with all methods from StringBuilder, this is just an example
    public CodeBuilder Clear()
    {
        builder.Clear();
        return this;
    }

    public int EnsureCapacity(int capacity)
    {
        return builder.EnsureCapacity(capacity);
    }
}