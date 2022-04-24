using Patterns.Factory.Interfaces;
using Patterns.Factory.Interfaces.Providers;
using Patterns.Factory.Models;

namespace Patterns.Factory.Concrete
{
    public class Startup
    {
        private readonly IExtensionProviderFactory _extensionProviderFactory;
        private readonly IProviderServerFactoryProvider _providerServerFactoryProvider;

        public Startup
            (
                IExtensionProviderFactory extensionProviderFactory,
                IProviderServerFactoryProvider providerServerFactoryProvider
            )
        {
            _extensionProviderFactory = extensionProviderFactory;
            _providerServerFactoryProvider = providerServerFactoryProvider;
        }

        public void Start()
        {
            IImage image = new Image()
            {
                DateTime = DateTime.Now,
                Description = "Image 1",
                Name = "Img1",
                Extension = _extensionProviderFactory.GetExtension(".png")
            };

            var serverProvider = _providerServerFactoryProvider.CreateServerProvider(image.Extension);
            bool result = serverProvider.SaveImage(image);

            Console.WriteLine($"Result: {result} - Server: {serverProvider.Server.Name}");
        }
    }
}
