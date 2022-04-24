using Patterns.Factory.Interfaces;

namespace Patterns.Factory.Models
{
    public class JpegExtension : IExtension
    {
        public string Name { get => "Jpeg"; }
        public string Extension { get => ".jpeg"; }
    }
}
