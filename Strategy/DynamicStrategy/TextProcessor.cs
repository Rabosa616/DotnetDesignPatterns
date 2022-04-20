using System.Collections.Generic;
using System.Text;

namespace Strategy.DynamicStrategy;

public class TextProcessor
{
    private readonly StringBuilder sb = new();
    private IListStrategy listStrategy;

    public void SetOutputFormat(OutputFormat format)
    {
        switch (format)
        {
            case OutputFormat.Markdown:
                listStrategy = new MarkdownListStrategy();
                break;

            case OutputFormat.Html:
                listStrategy = new HtmlListStrategy();
                break;
        }
    }

    public void AppendList(IEnumerable<string> items)
    {
        listStrategy.Start(sb);
        foreach (var item in items)
        {
            listStrategy.AddListItem(sb, item);
        }
        listStrategy.End(sb);
    }

    public override string ToString()
    {
        return sb.ToString();
    }

    public StringBuilder Clear()
    {
        return sb.Clear();
    }
}