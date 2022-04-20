using System.Collections.Generic;
using System.Text;

namespace Strategy.StaticStrategy;

public class TextProcessor<LS> where LS : IListStrategy, new()
{
    private readonly StringBuilder sb = new();
    private readonly IListStrategy listStrategy = new LS();

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