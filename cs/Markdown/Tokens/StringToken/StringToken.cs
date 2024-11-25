namespace Markdown.Tokens.StringToken;

public class StringToken(string value, int offset, int length, StringTokenType Type)
{
    public int Length = length;
    public int Offset = offset;
    public string Value = value;
    public StringTokenType Type;
}