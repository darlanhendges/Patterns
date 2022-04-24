using Patterns.Factory.Abstract;
using Patterns.Factory.Interfaces;
using Patterns.Factory.Models;

namespace Patterns.Factory.Concrete.Providers.Servers
{
    public class PngServerProvider : ServerProvider
    {
        public override IServer Server { get => new ServerPng(); }

        public override bool SaveImage(IImage image)
        {
            Console.WriteLine($"Saving into pngserver....{image.Name}");
            return true;
        }
    }
}
