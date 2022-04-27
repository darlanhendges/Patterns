using Patterns.RuleEngine.Concrete.Models;

namespace Patterns.RuleEngine.Interfaces
{
    public interface IDiscountRule
    {
        decimal CalculateDiscountPercentage(Customer customer);
    }
}
