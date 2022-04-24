using Patterns.Factory.Interfaces;

namespace Patterns.Factory.Models
{
    public  class ServerBitmap: IServer
    {
        public string Name => "ServerSky";
        public string Ip => "192.168.1.3";
        public IExtension ExtensionAllowed => new BitmapExtension();
    }
}
