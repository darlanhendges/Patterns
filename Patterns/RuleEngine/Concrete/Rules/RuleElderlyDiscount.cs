using Patterns.RuleEngine.Concrete.Models;
using Patterns.RuleEngine.Interfaces;

namespace Patterns.RuleEngine.Concrete.Rules
{
    public class RuleElderlyDiscount : IDiscountRule
    {
        public decimal CalculateDiscountPercentage(Customer customer)
        {
            if (customer.Birthday.Age() > 65)
            {
                return .20M;
            }

            return 0M;
        }
    }
}
