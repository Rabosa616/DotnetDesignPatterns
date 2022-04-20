using System.Text;

namespace Strategy.StaticStrategy;

public class MarkdownListStrategy : IListStrategy
{
    public void Start(StringBuilder sb)
    {
    }

    public void AddListItem(StringBuilder sb, string item)
    {
        sb.AppendLine($" * {item}");
    }

    public void End(StringBuilder sb)
    {
    }
}