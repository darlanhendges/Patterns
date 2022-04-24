using Patterns.Factory.Interfaces;
using Patterns.Factory.Interfaces.Providers;
using Patterns.Factory.Models;

namespace Patterns.Factory.Concrete.Providers
{
    public class ExtensionProviderFactory : IExtensionProviderFactory
    {
        public IExtension GetExtension(string extension)
        => extension switch
        {
            ".bmp" => new BitmapExtension(),
            ".png" => new PngExtension(),
            ".jpeg" => new JpegExtension(),
            _ => throw new NotImplementedException()
        };
    }
}