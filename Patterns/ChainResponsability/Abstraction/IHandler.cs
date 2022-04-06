namespace Patterns.ChainResponsability.Abstraction
{
    public interface IHandler<T>
    {
        void Handle(T request);
        IHandler<T> SetNext(IHandler<T> next);
    }
}
