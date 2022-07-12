using Patterns.Adapter.Models;

namespace Patterns.Adapter.Interfaces
{
    public interface ILegacyAdapter
    {
        void Add(ModelUpdated model);
    }
}
