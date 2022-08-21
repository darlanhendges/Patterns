using Patterns.Builder.Concrete;
using Patterns.Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder.Abstract
{
    public interface IHtmlBuilder
    {
        void AddChild(string childName, string childText);
        HtmlBuilder AddChildFluent(string childName, string childText);
        void Clear();
    }
}
