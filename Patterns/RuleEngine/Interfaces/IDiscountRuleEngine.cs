using Patterns.RuleEngine.Concrete.Models;

namespace Patterns.RuleEngine.Interfaces
{
    public interface IDiscountRuleEngine
    {
        decimal CalculateDiscountPercentage(Customer customer);
    }
}
