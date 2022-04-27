using Patterns.RuleEngine.Concrete.Models;
using Patterns.RuleEngine.Interfaces;

namespace Patterns.RuleEngine.Concrete.Rules
{
    public class RuleSeniorDiscount : IDiscountRule
    {
        public decimal CalculateDiscountPercentage(Customer customer)
        {
            if (customer.Birthday.Age() > 45)
            {
                return .15M;
            }

            return 0M;
        }
    }
}
