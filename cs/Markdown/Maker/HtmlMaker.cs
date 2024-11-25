using Markdown.Tokens.HtmlToken;
using Markdown.Tokens.StringToken;

namespace Markdown.Maker;

public class HtmlMaker : IMaker<RootToken>
{
    public RootToken MakeFromTokens(List<StringToken> tokens)
    {
        throw new NotImplementedException();
    }
}