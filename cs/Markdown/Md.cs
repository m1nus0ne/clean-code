using Markdown.Maker;
using Markdown.Parser;
using Markdown.Rendered;

namespace Markdown;

public class Md<TResult>
{
    public string Render(string input, IParser parser, IMaker<TResult> maker, IRenderer<TResult> renderer)
    {
        var tokens = new MarkdownParser().Parse(input);
        var model = maker.MakeFromTokens(tokens);
        return renderer.Render(model);
    }
}