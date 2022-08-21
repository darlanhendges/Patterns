using Patterns.Builder.Abstract;
using Patterns.Builder.Models;

namespace Patterns.Builder.Concrete
{
    public class HtmlBuilder : IHtmlBuilder
    {
        private readonly string rootName;
        private HtmlElement root;

        public HtmlBuilder(string _rootName)
        {
            rootName = _rootName;
            root = new HtmlElement(_rootName, "");
        }

        public void AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
        }

        public HtmlBuilder AddChildFluent(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void Clear()
        {
            root = new HtmlElement(rootName, String.Empty);
        }
    }
}
