using System.Text;

namespace Flyweight.TextFormatting;

public class FormattedText
{
    private readonly string plainText;
    private readonly bool[] capitalize;

    public FormattedText(string plainText)
    {
        this.plainText = plainText;
        capitalize = new bool[plainText.Length];
    }

    public void Capitalize(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            capitalize[i] = true;
        }
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        for (int i = 0; i < plainText.Length; i++)
        {
            var c = plainText[i];
            stringBuilder.Append(capitalize[i] ? char.ToUpper(c) : c);
        }

        return stringBuilder.ToString();
    }
}