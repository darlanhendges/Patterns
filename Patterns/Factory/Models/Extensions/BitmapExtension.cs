using Patterns.Factory.Interfaces;

namespace Patterns.Factory.Models
{
    public class BitmapExtension : IExtension
    {
        public string Name { get => "Bitmap"; }
        public string Extension { get => ".bmp"; }
    }
}
