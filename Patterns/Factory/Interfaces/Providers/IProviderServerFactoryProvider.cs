using Patterns.Factory.Abstract;

namespace Patterns.Factory.Interfaces.Providers
{
    public interface IProviderServerFactoryProvider
    {
        ServerProvider CreateServerProvider(IExtension extension);
    }
}
