namespace Patterns.Factory.Interfaces.Providers
{
    public interface IExtensionProviderFactory
    {
        IExtension GetExtension(string extension);
    }
}
