using Patterns.RuleEngine.Concrete.Models;
using Patterns.RuleEngine.Interfaces;

namespace Patterns.RuleEngine.Concrete
{
    public class DiscountRuleEngine : IDiscountRuleEngine
    {
        private readonly List<IDiscountRule> _rules = new();

        public DiscountRuleEngine(List<IDiscountRule> rules)
        {
            _rules.AddRange(rules);
        }

        public decimal CalculateDiscountPercentage(Customer customer)
        {
            decimal discount = 0M;
            
            foreach (var rule in _rules)
            {
                discount = Math.Max(discount, rule.CalculateDiscountPercentage(customer));
            }

            return discount;
        }
    }
}
