using Patterns.Factory.Interfaces;

namespace Patterns.Factory.Models
{
    public class Image : IImage
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte[] Data { get; set; } = null!;
        public DateTime DateTime { get; set; }
        public IExtension Extension { get; set; } = null!;
    }
}
