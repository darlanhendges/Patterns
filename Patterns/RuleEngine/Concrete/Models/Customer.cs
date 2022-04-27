namespace Patterns.RuleEngine.Concrete.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime Birthday { get; set; }
    }
}
