using Patterns.Factory.Interfaces;

namespace Patterns.Factory.Abstract
{
    public abstract class ServerProvider
    {
        public abstract IServer Server { get; }
        public abstract bool SaveImage(IImage image);
    }
}
