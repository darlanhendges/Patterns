namespace Patterns.Factory.Interfaces
{
    public interface IServer
    {
        string Name { get; }
        string Ip { get; }
        IExtension ExtensionAllowed { get; }
    }
}
