using Patterns.Factory.Interfaces;

namespace Patterns.Factory.Models
{
    public class ServerPng : IServer
    {
        public string Name => "ServerMoon";
        public string Ip => "192.168.1.2";
        public IExtension ExtensionAllowed => new PngExtension();
    }
}
