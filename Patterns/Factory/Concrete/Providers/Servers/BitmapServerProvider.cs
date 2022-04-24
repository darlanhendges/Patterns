using Patterns.Factory.Abstract;
using Patterns.Factory.Interfaces;
using Patterns.Factory.Models;

namespace Patterns.Factory.Concrete.Providers.Servers
{
    public class BitmapServerProvider : ServerProvider
    {
        public override IServer Server { get => new ServerBitmap(); }

        public override bool SaveImage(IImage image)
        {
            Console.WriteLine($"Saving into bitmapserver....{image.Name}");
            return true;
        }
    }
}
