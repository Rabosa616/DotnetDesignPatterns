using System.Collections.Generic;
using System.Text;

namespace Flyweight.TextFormatting;

public class BetterFormatedText
{
    private readonly string plainText;
    private readonly List<TextRange> formatting = new();

    public BetterFormatedText(string plainText)
    {
        this.plainText = plainText;
    }

    public TextRange GetRange(int start, int end)
    {
        var range = new TextRange { Start = start, End = end };
        formatting.Add(range);
        return range;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        for (int i = 0; i < plainText.Length; i++)
        {
            var c = plainText[i];
            foreach (var range in formatting)
            {
                if (range.Covers(i) && range.Capitalize)
                {
                    c = char.ToUpper(c);
                }
            }

            sb.Append(c);
        }

        return sb.ToString();
    }

    public class TextRange
    {
        public int Start { get; set; }

        public int End { get; set; }

        public bool Capitalize { get; set; }

        public bool Bold { get; set; }

        public bool Italic { get; set; }

        public bool Covers(int position)
        {
            return position >= Start && position <= End;
        }
    }
}