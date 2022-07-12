namespace Patterns.Singleton.Concrete
{
    public sealed class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> _instance = new(() => new SingletonLazy());

        public static SingletonLazy Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
