using Patterns.Adapter.Interfaces;
using Patterns.Adapter.Models;

namespace Patterns.Adapter.Concrete
{
    public sealed class LegacyAdapter : ILegacyAdapter
    {
        private readonly ILegacyService _service;

        public LegacyAdapter(ILegacyService legacyService)
        {
            _service = legacyService;
        }

        public void Add(ModelUpdated model)
        {
            var legacyModel = ConvertToServiceFormat(model);
            _service.Add(legacyModel);
        }

        private Legacy ConvertToServiceFormat(ModelUpdated model)
        {
            return new Legacy(model.Id.ToString(), model.Name);
        }
    }
}
