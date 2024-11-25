using Markdown.Tokens.StringToken;

namespace Markdown.Parser;

public interface IParser
{
    public List<StringToken> Parse(string input);
}