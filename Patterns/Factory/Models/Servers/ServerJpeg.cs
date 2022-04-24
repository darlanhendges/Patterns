using Patterns.Factory.Interfaces;

namespace Patterns.Factory.Models
{
    public class ServerJpeg : IServer
    {
        public string Name => "ServerDog";
        public string Ip => "192.168.1.1";
        public IExtension ExtensionAllowed => new JpegExtension();
    }
}
