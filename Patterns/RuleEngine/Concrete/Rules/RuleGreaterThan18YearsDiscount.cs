using Patterns.RuleEngine.Concrete.Models;
using Patterns.RuleEngine.Interfaces;

namespace Patterns.RuleEngine.Concrete.Rules
{
    public class RuleGreaterThan18YearsDiscount : IDiscountRule
    {
        public decimal CalculateDiscountPercentage(Customer customer)
        {
            if (customer.Birthday.Age() > 18)
            {
                return .10M;
            }

            return 0M;
        }
    }
}
