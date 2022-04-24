using Patterns.Factory.Abstract;
using Patterns.Factory.Concrete.Providers.Servers;
using Patterns.Factory.Interfaces;
using Patterns.Factory.Interfaces.Providers;

namespace Patterns.Factory.Concrete.Providers
{
    public class ServerProviderFactory : IProviderServerFactoryProvider
    {
        public ServerProvider CreateServerProvider(IExtension extension)
        => extension.Name switch
        {
            "Bitmap" => new BitmapServerProvider(),
            "Png" => new PngServerProvider(),
            "Jpeg" => new JpegServerProvider(),
            _ => throw new NotImplementedException(),
        };
    }
}
