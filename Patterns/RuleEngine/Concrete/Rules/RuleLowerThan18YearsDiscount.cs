using Patterns.RuleEngine.Concrete.Models;
using Patterns.RuleEngine.Interfaces;

namespace Patterns.RuleEngine.Concrete.Rules
{
    public class RuleLowerThan18YearsDiscount: IDiscountRule
    {
        public decimal CalculateDiscountPercentage(Customer customer)
        {
            if (customer.Birthday.Age() < 18)
            {
                return .05M;
            }

            return 0M;
        }
    }
}
