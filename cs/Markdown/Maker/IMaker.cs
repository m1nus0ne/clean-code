using Markdown.Tokens.StringToken;

namespace Markdown.Maker;

public interface IMaker<T>
{
    public T MakeFromTokens(List<StringToken> tokens);
}