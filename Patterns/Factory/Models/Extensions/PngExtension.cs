using Patterns.Factory.Interfaces;

namespace Patterns.Factory.Models
{
    public class PngExtension : IExtension
    {
        public string Name { get => "Png"; }
        public string Extension { get => ".png"; }
    }
}
