using Patterns.Adapter.Interfaces;
using Patterns.Adapter.Models;

namespace Patterns.Adapter.Concrete
{
    public sealed class LegacyService : ILegacyService
    {
        private List<Legacy> _list = new();

        public void Add(Legacy model)
        {
            _list.Add(model);
        }
    }
}
