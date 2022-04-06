namespace Patterns.ChainResponsability.Abstraction
{
    public abstract class Handler<T>
    {
        private IHandler<T> Next { get; set; } = null!;

        public virtual void Handle(T request)
        {
            Next?.Handle(request);
        }

        public IHandler<T> SetNext(IHandler<T> next)
        {
            Next = next;
            return Next;
        }
    }
}
