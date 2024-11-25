namespace Markdown.Tokens;

public abstract class BaseHtmlToken
{
    public List<BaseHtmlToken>? Children { get; private protected set; }
    public string Value { get; private protected set; }

    public BaseHtmlToken(List<BaseHtmlToken>? children)
    {
        Children = children;
    }
}