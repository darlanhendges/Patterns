using Patterns.Factory.Abstract;
using Patterns.Factory.Interfaces;
using Patterns.Factory.Models;

namespace Patterns.Factory.Concrete.Providers.Servers
{
    public class JpegServerProvider : ServerProvider
    {
        public override IServer Server { get => new ServerJpeg(); }

        public override bool SaveImage(IImage image)
        {
            Console.WriteLine($"Saving into jpegserver....{image.Name}");
            return true;
        }
    }
}
